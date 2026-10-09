#nullable disable
namespace ApiSencilla;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    #region Código generado por el diseñador de Windows Forms

    private void InitializeComponent()
    {
        lblTitulo = new Label();
        lblDescripcion = new Label();
        panelConsulta = new Panel();
        lblUrl = new Label();
        txtUrl = new TextBox();
        btnConsultar = new Button();
        btnAbrirJson = new Button();
        btnGuardarJson = new Button();
        btnGuardarTxt = new Button();
        btnGuardarCsv = new Button();
        btnCopiar = new Button();
        btnLimpiar = new Button();
        grupoRespuesta = new GroupBox();
        txtRespuesta = new TextBox();
        lblEstado = new Label();
        panelConsulta.SuspendLayout();
        grupoRespuesta.SuspendLayout();
        SuspendLayout();
        // lblTitulo
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(16, 105, 103);
        lblTitulo.Location = new Point(24, 18);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(360, 41);
        lblTitulo.Text = "VISOR DE DATOS API";
        // lblDescripcion
        lblDescripcion.AutoSize = true;
        lblDescripcion.ForeColor = Color.FromArgb(77, 95, 97);
        lblDescripcion.Location = new Point(28, 67);
        lblDescripcion.Name = "lblDescripcion";
        lblDescripcion.Text = "Consulta una API o abre tu propio archivo JSON.";
        // panelConsulta
        panelConsulta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        panelConsulta.BackColor = Color.White;
        panelConsulta.Controls.Add(lblUrl);
        panelConsulta.Controls.Add(txtUrl);
        panelConsulta.Controls.Add(btnConsultar);
        panelConsulta.Location = new Point(28, 106);
        panelConsulta.Name = "panelConsulta";
        panelConsulta.Size = new Size(884, 88);
        // lblUrl
        lblUrl.AutoSize = true;
        lblUrl.Location = new Point(12, 10);
        lblUrl.Name = "lblUrl";
        lblUrl.Text = "Dirección de la API";
        // txtUrl
        txtUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtUrl.Location = new Point(12, 43);
        txtUrl.Name = "txtUrl";
        txtUrl.Size = new Size(704, 25);
        txtUrl.TabIndex = 0;
        txtUrl.Text = "https://v2.jokeapi.dev/joke/Any?lang=es&safe-mode";
        // btnConsultar
        btnConsultar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnConsultar.BackColor = Color.FromArgb(16, 105, 103);
        btnConsultar.FlatStyle = FlatStyle.Flat;
        btnConsultar.ForeColor = Color.White;
        btnConsultar.Location = new Point(736, 34);
        btnConsultar.Name = "btnConsultar";
        btnConsultar.Size = new Size(136, 40);
        btnConsultar.TabIndex = 1;
        btnConsultar.Text = "Consultar";
        btnConsultar.UseVisualStyleBackColor = false;
        btnConsultar.Click += btnConsultar_Click;
        // btnAbrirJson
        btnAbrirJson.BackColor = Color.White;
        btnAbrirJson.Location = new Point(28, 212);
        btnAbrirJson.Name = "btnAbrirJson";
        btnAbrirJson.Size = new Size(132, 36);
        btnAbrirJson.TabIndex = 2;
        btnAbrirJson.Text = "Abrir JSON";
        btnAbrirJson.UseVisualStyleBackColor = false;
        btnAbrirJson.Click += btnAbrirJson_Click;
        // btnGuardarJson
        btnGuardarJson.BackColor = Color.White;
        btnGuardarJson.Location = new Point(174, 212);
        btnGuardarJson.Name = "btnGuardarJson";
        btnGuardarJson.Size = new Size(132, 36);
        btnGuardarJson.TabIndex = 3;
        btnGuardarJson.Text = "Guardar JSON";
        btnGuardarJson.UseVisualStyleBackColor = false;
        btnGuardarJson.Click += btnGuardarJson_Click;
        // btnGuardarTxt
        btnGuardarTxt.BackColor = Color.White;
        btnGuardarTxt.Location = new Point(320, 212);
        btnGuardarTxt.Name = "btnGuardarTxt";
        btnGuardarTxt.Size = new Size(132, 36);
        btnGuardarTxt.TabIndex = 4;
        btnGuardarTxt.Text = "Guardar TXT";
        btnGuardarTxt.UseVisualStyleBackColor = false;
        btnGuardarTxt.Click += btnGuardarTxt_Click;
        // btnGuardarCsv
        btnGuardarCsv.BackColor = Color.White;
        btnGuardarCsv.Location = new Point(466, 212);
        btnGuardarCsv.Name = "btnGuardarCsv";
        btnGuardarCsv.Size = new Size(132, 36);
        btnGuardarCsv.TabIndex = 5;
        btnGuardarCsv.Text = "Guardar CSV";
        btnGuardarCsv.UseVisualStyleBackColor = false;
        btnGuardarCsv.Click += btnGuardarCsv_Click;
        // btnCopiar
        btnCopiar.BackColor = Color.White;
        btnCopiar.Location = new Point(612, 212);
        btnCopiar.Name = "btnCopiar";
        btnCopiar.Size = new Size(132, 36);
        btnCopiar.TabIndex = 6;
        btnCopiar.Text = "Copiar";
        btnCopiar.UseVisualStyleBackColor = false;
        btnCopiar.Click += btnCopiar_Click;
        // btnLimpiar
        btnLimpiar.BackColor = Color.White;
        btnLimpiar.Location = new Point(758, 212);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new Size(154, 36);
        btnLimpiar.TabIndex = 7;
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.UseVisualStyleBackColor = false;
        btnLimpiar.Click += btnLimpiar_Click;
        // grupoRespuesta
        grupoRespuesta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        grupoRespuesta.Controls.Add(txtRespuesta);
        grupoRespuesta.Location = new Point(28, 270);
        grupoRespuesta.Name = "grupoRespuesta";
        grupoRespuesta.Size = new Size(884, 318);
        grupoRespuesta.Text = "Contenido recibido";
        // txtRespuesta
        txtRespuesta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtRespuesta.BackColor = Color.White;
        txtRespuesta.Font = new Font("Consolas", 10.5F);
        txtRespuesta.Location = new Point(14, 28);
        txtRespuesta.MaxLength = int.MaxValue;
        txtRespuesta.Multiline = true;
        txtRespuesta.Name = "txtRespuesta";
        txtRespuesta.ReadOnly = true;
        txtRespuesta.ScrollBars = ScrollBars.Both;
        txtRespuesta.Size = new Size(856, 276);
        txtRespuesta.TabIndex = 8;
        txtRespuesta.WordWrap = false;
        // lblEstado
        lblEstado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblEstado.ForeColor = Color.FromArgb(16, 105, 103);
        lblEstado.Location = new Point(28, 608);
        lblEstado.Name = "lblEstado";
        lblEstado.Size = new Size(884, 24);
        lblEstado.Text = "Listo. Escribe una URL y pulsa Consultar.";
        // Form1
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(235, 244, 242);
        ClientSize = new Size(940, 650);
        Controls.Add(lblTitulo);
        Controls.Add(lblDescripcion);
        Controls.Add(panelConsulta);
        Controls.Add(btnAbrirJson);
        Controls.Add(btnGuardarJson);
        Controls.Add(btnGuardarTxt);
        Controls.Add(btnGuardarCsv);
        Controls.Add(btnCopiar);
        Controls.Add(btnLimpiar);
        Controls.Add(grupoRespuesta);
        Controls.Add(lblEstado);
        Font = new Font("Segoe UI", 10F);
        MinimumSize = new Size(956, 689);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Visor de datos";
        panelConsulta.ResumeLayout(false);
        panelConsulta.PerformLayout();
        grupoRespuesta.ResumeLayout(false);
        grupoRespuesta.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitulo;
    private Label lblDescripcion;
    private Panel panelConsulta;
    private Label lblUrl;
    private TextBox txtUrl;
    private Button btnConsultar;
    private Button btnAbrirJson;
    private Button btnGuardarJson;
    private Button btnGuardarTxt;
    private Button btnGuardarCsv;
    private Button btnCopiar;
    private Button btnLimpiar;
    private GroupBox grupoRespuesta;
    private TextBox txtRespuesta;
    private Label lblEstado;
}
