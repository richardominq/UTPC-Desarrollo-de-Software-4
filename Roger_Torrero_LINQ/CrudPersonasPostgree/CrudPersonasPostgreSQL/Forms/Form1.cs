using CrudPersonasPostgreSQL.Data;
using CrudPersonasPostgreSQL.Models;

namespace CrudPersonasPostgreSQL.Forms;

public partial class Form1 : Form
{
    private readonly PeopleRepository repository = new();
    private bool busy;

    public Form1()
    {
        InitializeComponent(); // No se conecta a la base al abrir el diseñador.
    }

    private async void Form1_Load(object? sender, EventArgs e)
    {
        await LoadPeopleAsync();
    }

    private async Task LoadPeopleAsync()
    {
        if (busy) return;
        SetBusy(true);
        lblStatus.Text = "Consultando personas...";
        try
        {
            List<Person> people = await repository.GetAsync(txtBuscar.Text);
            dgvPeople.DataSource = people;
            dgvPeople.ClearSelection();
            dgvPeople.CurrentCell = null;
            lblCount.Text = people.Count + (people.Count == 1 ? " persona" : " personas");
            lblEmpty.Visible = people.Count == 0;
            lblConnection.Text = "●  Conectado";
            lblConnection.ForeColor = Color.FromArgb(94, 234, 212);
            lblStatus.Text = people.Count == 0
                ? "Sin resultados. Cambie la búsqueda o agregue una persona."
                : "Seleccione una persona para editarla o eliminarla.";
        }
        catch (Exception ex)
        {
            // Se evita operar sobre una selección anterior si falla una nueva consulta.
            dgvPeople.DataSource = null;
            lblCount.Text = "Sin cargar";
            lblEmpty.Visible = true;
            lblConnection.Text = "●  Sin conexión";
            lblConnection.ForeColor = Color.FromArgb(253, 186, 116);
            lblStatus.Text = "Revise la configuración y pulse Actualizar para reintentar.";
            UiMessages.ShowError(this, ex);
        }
        finally
        {
            SetBusy(false);
        }
    }

    private void SetBusy(bool value)
    {
        busy = value;
        UseWaitCursor = value;
        pnlContent.Enabled = !value;
        UpdateSelectionButtons();
    }

    private Person? SelectedPerson()
    {
        if (dgvPeople.SelectedRows.Count == 0) return null;
        return dgvPeople.SelectedRows[0].DataBoundItem as Person;
    }

    private void UpdateSelectionButtons()
    {
        bool selected = !busy && SelectedPerson() != null;
        btnEditar.Enabled = selected;
        btnEliminar.Enabled = selected;
    }

    private void dgvPeople_SelectionChanged(object? sender, EventArgs e) => UpdateSelectionButtons();

    private async void btnBuscar_Click(object? sender, EventArgs e) => await LoadPeopleAsync();

    private async void btnActualizar_Click(object? sender, EventArgs e)
    {
        txtBuscar.Clear();
        await LoadPeopleAsync();
    }

    private async void txtBuscar_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter) return;
        e.SuppressKeyPress = true;
        await LoadPeopleAsync();
    }

    private async void btnNuevo_Click(object? sender, EventArgs e)
    {
        using var form = new FrmPersona();
        if (form.ShowDialog(this) == DialogResult.OK)
        {
            txtBuscar.Clear();
            await LoadPeopleAsync();
        }
    }

    private async Task EditSelectedAsync()
    {
        Person? person = SelectedPerson();
        if (person == null) return;
        using var form = new FrmPersona(person.Id);
        if (form.ShowDialog(this) == DialogResult.OK)
            await LoadPeopleAsync();
    }

    private async void btnEditar_Click(object? sender, EventArgs e) => await EditSelectedAsync();

    private async void dgvPeople_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (!busy && e.RowIndex >= 0) await EditSelectedAsync();
    }

    private async void btnEliminar_Click(object? sender, EventArgs e)
    {
        Person? person = SelectedPerson();
        if (person == null || busy) return;
        DialogResult answer = MessageBox.Show(this,
            $"¿Desea eliminar a {person.Name} (ID {person.Id})?",
            "Confirmar eliminación", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        if (answer != DialogResult.Yes) return;

        SetBusy(true);
        try
        {
            if (!await repository.DeleteAsync(person.Id))
                MessageBox.Show(this, "El registro ya no existe. Se actualizará la lista.", "Personas");
        }
        catch (Exception ex) { UiMessages.ShowError(this, ex); }
        finally { SetBusy(false); }
        await LoadPeopleAsync();
    }

    private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
    {
        // No se destruyen controles mientras una operación espera respuesta de la base.
        if (busy && e.CloseReason == CloseReason.UserClosing) e.Cancel = true;
    }
}
