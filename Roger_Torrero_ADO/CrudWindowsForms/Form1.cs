using System;
using System.Windows.Forms;

namespace CrudWindowsForms
{
    public partial class Form1 : Form
    {
        private readonly PeopleDB db = new PeopleDB();

        public Form1()
        {
            InitializeComponent();
        }

        // Cargar personas desde SQL Server y quitar la selección anterior.
        private void RefreshPeople(string message = "Lista actualizada.")
        {
            try
            {
                var people = db.Get();
                dgvPeople.DataSource = people;
                dgvPeople.ClearSelection();
                lblEstado.Text = people.Count + " persona(s)  |  " +
                    (people.Count == 0 ? "No hay registros. Pulse Nuevo para agregar." : message);
            }
            catch (Exception ex)
            {
                dgvPeople.DataSource = null;
                lblEstado.Text = "No se pudo cargar la lista. Revise la conexión y pulse Actualizar.";
                MessageBox.Show(this, "No se pudo consultar SQL Server. Revise App.config y ejecute BaseDatos.sql.\n\n" + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int? GetSelectedId()
        {
            if (dgvPeople.SelectedRows.Count == 0) return null;
            var person = dgvPeople.SelectedRows[0].DataBoundItem as People;
            return person == null ? (int?)null : person.Id;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshPeople("Seleccione una fila para editar o eliminar.");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            RefreshPeople();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (var form = new FrmNuevo())
                if (form.ShowDialog(this) == DialogResult.OK)
                    RefreshPeople("Persona agregada correctamente.");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (!id.HasValue)
            {
                MessageBox.Show(this, "Seleccione una persona de la tabla.", "Editar persona", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (var form = new FrmNuevo(id.Value))
                if (form.ShowDialog(this) == DialogResult.OK)
                    RefreshPeople("Cambios guardados correctamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (!id.HasValue)
            {
                MessageBox.Show(this, "Seleccione una persona de la tabla.", "Eliminar persona", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Confirmar antes de eliminar; No es la respuesta predeterminada.
            var answer = MessageBox.Show(this, "¿Desea eliminar la persona con ID " + id.Value + "?\nEsta acción elimina el registro de SQL Server.",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (answer != DialogResult.Yes) return;
            try
            {
                int affected = db.Delete(id.Value);
                RefreshPeople(affected == 1 ? "Persona eliminada correctamente." : "El registro ya no existe. Lista actualizada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "No se pudo eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
