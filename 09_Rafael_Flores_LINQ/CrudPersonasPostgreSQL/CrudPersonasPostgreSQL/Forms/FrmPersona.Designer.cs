#nullable enable
using System.Drawing;
using System.Windows.Forms;

namespace CrudPersonasPostgreSQL.Forms;

partial class FrmPersona
{
    private System.ComponentModel.IContainer? components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        pnlHeader = new Panel();
        lblRecord = new Label();
        lblTitle = new Label();
        lblSubtitle = new Label();
        pnlFields = new Panel();
        lblName = new Label();
        txtName = new TextBox();
        lblNameHelp = new Label();
        lblAge = new Label();
        txtAge = new TextBox();
        lblAgeHelp = new Label();
        lblRequired = new Label();
        pnlFooter = new Panel();
        btnCancelar = new Button();
        btnGuardar = new Button();
        errorProvider = new ErrorProvider(components);
        pnlHeader.SuspendLayout();
        pnlFields.SuspendLayout();
        pnlFooter.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        SuspendLayout();
        pnlHeader.Name = "pnlHeader";
        lblRecord.Name = "lblRecord";
        lblTitle.Name = "lblTitle";
        lblSubtitle.Name = "lblSubtitle";
        pnlFields.Name = "pnlFields";
        lblName.Name = "lblName";
        txtName.Name = "txtName";
        lblNameHelp.Name = "lblNameHelp";
        lblAge.Name = "lblAge";
        txtAge.Name = "txtAge";
        lblAgeHelp.Name = "lblAgeHelp";
        lblRequired.Name = "lblRequired";
        pnlFooter.Name = "pnlFooter";
        btnCancelar.Name = "btnCancelar";
        btnGuardar.Name = "btnGuardar";
        // pnlHeader
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Height = 126;
        pnlHeader.BackColor = Color.FromArgb(15, 23, 42);
        pnlHeader.Size = new Size(500, 126);
        // lblRecord
        lblRecord.Text = "NUEVO REGISTRO";
        lblRecord.Location = new Point(30, 22);
        lblRecord.Size = new Size(440, 22);
        lblRecord.ForeColor = Color.FromArgb(94, 234, 212);
        lblRecord.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        lblRecord.AutoEllipsis = true;
        // lblTitle
        lblTitle.Text = "Nueva persona";
        lblTitle.Location = new Point(30, 49);
        lblTitle.Size = new Size(440, 34);
        lblTitle.ForeColor = Color.White;
        lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitle.AutoEllipsis = true;
        // lblSubtitle
        lblSubtitle.Text = "Complete el nombre y la edad de la persona.";
        lblSubtitle.Location = new Point(30, 94);
        lblSubtitle.Size = new Size(440, 23);
        lblSubtitle.ForeColor = Color.FromArgb(203, 213, 225);
        lblSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        lblSubtitle.AutoEllipsis = true;
        pnlHeader.Controls.Add(lblRecord);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Controls.Add(lblSubtitle);
        // pnlFields
        pnlFields.Dock = DockStyle.Fill;
        pnlFields.BackColor = Color.White;
        pnlFields.Size = new Size(500, 302);
        // lblName
        lblName.Text = "Nombre completo";
        lblName.Location = new Point(30, 26);
        lblName.Size = new Size(440, 24);
        lblName.ForeColor = Color.FromArgb(30, 41, 59);
        lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblName.AutoEllipsis = true;
        // txtName
        txtName.Location = new Point(30, 57);
        txtName.Size = new Size(430, 32);
        txtName.MaxLength = 100;
        txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
        txtName.PlaceholderText = "Ej. Ana Rodríguez";
        txtName.TabIndex = 0;
        // lblNameHelp
        lblNameHelp.Text = "Hasta 100 caracteres.";
        lblNameHelp.Location = new Point(30, 99);
        lblNameHelp.Size = new Size(430, 23);
        lblNameHelp.ForeColor = Color.FromArgb(100, 116, 139);
        lblNameHelp.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        lblNameHelp.AutoEllipsis = true;
        // lblAge
        lblAge.Text = "Edad";
        lblAge.Location = new Point(30, 141);
        lblAge.Size = new Size(430, 24);
        lblAge.ForeColor = Color.FromArgb(30, 41, 59);
        lblAge.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblAge.AutoEllipsis = true;
        // txtAge
        txtAge.Location = new Point(30, 172);
        txtAge.Size = new Size(140, 32);
        txtAge.MaxLength = 3;
        txtAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
        txtAge.PlaceholderText = "Ej. 20";
        txtAge.TabIndex = 1;
        // lblAgeHelp
        lblAgeHelp.Text = "Número entero entre 0 y 120 años.";
        lblAgeHelp.Location = new Point(30, 214);
        lblAgeHelp.Size = new Size(430, 24);
        lblAgeHelp.ForeColor = Color.FromArgb(100, 116, 139);
        lblAgeHelp.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        lblAgeHelp.AutoEllipsis = true;
        // lblRequired
        lblRequired.Text = "Ambos campos son obligatorios.";
        lblRequired.Location = new Point(30, 260);
        lblRequired.Size = new Size(430, 25);
        lblRequired.ForeColor = Color.FromArgb(100, 116, 139);
        lblRequired.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        lblRequired.AutoEllipsis = true;
        pnlFields.Controls.Add(lblName);
        pnlFields.Controls.Add(txtName);
        pnlFields.Controls.Add(lblNameHelp);
        pnlFields.Controls.Add(lblAge);
        pnlFields.Controls.Add(txtAge);
        pnlFields.Controls.Add(lblAgeHelp);
        pnlFields.Controls.Add(lblRequired);
        // pnlFooter
        pnlFooter.Dock = DockStyle.Bottom;
        pnlFooter.Height = 88;
        pnlFooter.BackColor = Color.FromArgb(244, 247, 251);
        pnlFooter.Size = new Size(500, 88);
        // btnCancelar
        btnCancelar.Text = "Cancelar";
        btnCancelar.Location = new Point(166, 22);
        btnCancelar.Size = new Size(116, 42);
        btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnCancelar.BackColor = Color.White;
        btnCancelar.ForeColor = Color.FromArgb(30, 41, 59);
        btnCancelar.FlatStyle = FlatStyle.Flat;
        btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
        btnCancelar.FlatAppearance.BorderSize = 1;
        btnCancelar.Cursor = Cursors.Hand;
        btnCancelar.UseVisualStyleBackColor = false;
        btnCancelar.TabIndex = 0;
        // btnGuardar
        btnGuardar.Text = "Guardar cambios";
        btnGuardar.Location = new Point(294, 22);
        btnGuardar.Size = new Size(176, 42);
        btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnGuardar.BackColor = Color.FromArgb(13, 148, 136);
        btnGuardar.ForeColor = Color.White;
        btnGuardar.FlatStyle = FlatStyle.Flat;
        btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(13, 148, 136);
        btnGuardar.FlatAppearance.BorderSize = 1;
        btnGuardar.Cursor = Cursors.Hand;
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.TabIndex = 0;
        btnCancelar.TabIndex = 3;
        btnGuardar.TabIndex = 2;
        btnCancelar.Click += btnCancelar_Click;
        btnGuardar.Click += btnGuardar_Click;
        pnlFooter.Controls.Add(btnCancelar);
        pnlFooter.Controls.Add(btnGuardar);
        // errorProvider
        errorProvider.ContainerControl = this;
        errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(500, 516);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Name = "FrmPersona";
        Text = "Nueva persona";
        AcceptButton = btnGuardar;
        CancelButton = btnCancelar;
        Controls.Add(pnlFields);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);
        Load += FrmPersona_Load;
        FormClosing += FrmPersona_FormClosing;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        pnlFooter.ResumeLayout(false);
        pnlFooter.PerformLayout();
        pnlFields.ResumeLayout(false);
        pnlFields.PerformLayout();
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
    #endregion

    private Panel pnlHeader = null!;
    private Label lblRecord = null!;
    private Label lblTitle = null!;
    private Label lblSubtitle = null!;
    private Panel pnlFields = null!;
    private Label lblName = null!;
    private TextBox txtName = null!;
    private Label lblNameHelp = null!;
    private Label lblAge = null!;
    private TextBox txtAge = null!;
    private Label lblAgeHelp = null!;
    private Label lblRequired = null!;
    private Panel pnlFooter = null!;
    private Button btnCancelar = null!;
    private Button btnGuardar = null!;
    private ErrorProvider errorProvider = null!;
}
