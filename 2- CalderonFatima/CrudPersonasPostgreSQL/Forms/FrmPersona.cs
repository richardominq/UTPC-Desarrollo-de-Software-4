using CrudPersonasPostgreSQL.Data;
using CrudPersonasPostgreSQL.Models;

namespace CrudPersonasPostgreSQL.Forms;

public partial class FrmPersona : Form
{
    private readonly PeopleRepository repository = new();
    private readonly int? personId;
    private bool busy;

    
    public FrmPersona()
    {
        InitializeComponent();
    }

    public FrmPersona(int id) : this()
    {
        personId = id;
        Text = "Editar persona";
        lblTitle.Text = "Editar persona";
        lblSubtitle.Text = "Actualice el nombre y la edad del registro.";
        lblRecord.Text = "REGISTRO · ID " + id;
    }

    private async void FrmPersona_Load(object? sender, EventArgs e)
    {
        if (!personId.HasValue) return;
        SetBusy(true);
        try
        {
            Person? person = await repository.GetByIdAsync(personId.Value);
            if (person == null)
            {
                MessageBox.Show(this, "El registro ya no existe. Actualice la lista.", "Personas");
                SetBusy(false);
                DialogResult = DialogResult.Cancel;
                return;
            }
            txtName.Text = person.Name;
            txtAge.Text = person.Age.ToString();
        }
        catch (Exception ex)
        {
            UiMessages.ShowError(this, ex);
            SetBusy(false);
            DialogResult = DialogResult.Cancel;
        }
        finally { SetBusy(false); }
    }

    private void SetBusy(bool value)
    {
        busy = value;
        UseWaitCursor = value;
        pnlFields.Enabled = !value;
        btnGuardar.Enabled = !value;
        btnCancelar.Enabled = !value;
        btnGuardar.Text = value ? "Espere..." : "Guardar cambios";
    }

    private async void btnGuardar_Click(object? sender, EventArgs e)
    {
        if (busy) return;
        errorProvider.Clear();
        string name = txtName.Text.Trim();
        if (string.IsNullOrWhiteSpace(name) || name.Length > 100)
        {
            errorProvider.SetError(txtName, "Escriba un nombre de 1 a 100 caracteres.");
            txtName.Focus();
            return;
        }
        if (!int.TryParse(txtAge.Text.Trim(), out int age) || age < 0 || age > 120)
        {
            errorProvider.SetError(txtAge, "Escriba una edad entera entre 0 y 120.");
            txtAge.Focus();
            return;
        }

        SetBusy(true);
        try
        {
            if (personId.HasValue)
            {
                if (!await repository.UpdateAsync(personId.Value, name, age))
                {
                    MessageBox.Show(this, "El registro ya no existe. Cierre esta ventana y actualice la lista.", "Personas");
                    return;
                }
            }
            else
            {
                await repository.AddAsync(name, age);
            }
            SetBusy(false);
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex) { UiMessages.ShowError(this, ex); }
        finally { SetBusy(false); }
    }

    private void btnCancelar_Click(object? sender, EventArgs e)
    {
        if (!busy) DialogResult = DialogResult.Cancel;
    }

    private void FrmPersona_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (busy && e.CloseReason == CloseReason.UserClosing) e.Cancel = true;
    }
}
