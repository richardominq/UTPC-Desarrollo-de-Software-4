using System;
using System.Windows.Forms;

namespace CrudWindowsForms
{
    public partial class FrmNuevo : Form
    {
        private readonly PeopleDB db = new PeopleDB();
        private readonly int? id;

        public FrmNuevo() : this(null) { }

        public FrmNuevo(int? id)
        {
            InitializeComponent();
            this.id = id;
            Text = id.HasValue ? "Editar persona" : "Nueva persona";
            lblTitulo.Text = Text;
        }

        private void FrmNuevo_Load(object sender, EventArgs e)
        {
            if (!id.HasValue) return;
            try
            {
                People person = db.GetById(id.Value);
                if (person == null)
                {
                    MessageBox.Show(this, "El registro ya no existe. Actualice la lista.", "Editar persona", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.Cancel;
                    Close();
                    return;
                }
                txtName.Text = person.Name;
                txtEdad.Text = person.Age.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "No se pudo cargar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private bool ValidateInput(out string name, out int age)
        {
            name = txtName.Text.Trim();
            age = 0;
            errorProvider.Clear();
            lblValidacion.Text = "";
            if (string.IsNullOrWhiteSpace(name) || name.Length > 100)
            {
                lblValidacion.Text = "Escriba un nombre de 1 a 100 caracteres.";
                errorProvider.SetError(txtName, lblValidacion.Text);
                txtName.Focus();
                return false;
            }
            if (!int.TryParse(txtEdad.Text.Trim(), out age) || age < 0 || age > 120)
            {
                lblValidacion.Text = "La edad debe ser un entero entre 0 y 120.";
                errorProvider.SetError(txtEdad, lblValidacion.Text);
                txtEdad.Focus();
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar antes de enviar los parámetros a SQL Server.
            string name;
            int age;
            if (!ValidateInput(out name, out age)) return;
            try
            {
                int affected = id.HasValue ? db.Update(id.Value, name, age) : db.Add(name, age);
                if (affected != 1)
                {
                    MessageBox.Show(this, "No se guardó el registro. Puede haber sido eliminado; cancele y actualice la lista.", "Guardar persona", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "No se pudo guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
