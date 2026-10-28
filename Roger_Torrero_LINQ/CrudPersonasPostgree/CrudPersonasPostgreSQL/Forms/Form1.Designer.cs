#nullable enable
using System.Drawing;
using System.Windows.Forms;

namespace CrudPersonasPostgreSQL.Forms;

partial class Form1
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
        pnlSidebar = new Panel();
        lblLogo = new Label();
        lblBrand = new Label();
        lblBrandSub = new Label();
        lblNav = new Label();
        pnlDivider = new Panel();
        lblDatabase = new Label();
        lblProvider = new Label();
        lblConnection = new Label();
        pnlContent = new Panel();
        pnlHeader = new Panel();
        lblEyebrow = new Label();
        lblTitle = new Label();
        lblSubtitle = new Label();
        lblCount = new Label();
        pnlSearch = new Panel();
        lblSearch = new Label();
        txtBuscar = new TextBox();
        btnBuscar = new Button();
        btnActualizar = new Button();
        pnlActions = new Panel();
        btnNuevo = new Button();
        btnEditar = new Button();
        btnEliminar = new Button();
        pnlGrid = new Panel();
        dgvPeople = new DataGridView();
        colId = new DataGridViewTextBoxColumn();
        colName = new DataGridViewTextBoxColumn();
        colAge = new DataGridViewTextBoxColumn();
        lblEmpty = new Label();
        pnlStatus = new Panel();
        lblStatus = new Label();
        pnlSidebar.SuspendLayout();
        pnlDivider.SuspendLayout();
        pnlContent.SuspendLayout();
        pnlHeader.SuspendLayout();
        pnlSearch.SuspendLayout();
        pnlActions.SuspendLayout();
        pnlGrid.SuspendLayout();
        pnlStatus.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
        SuspendLayout();
        pnlSidebar.Name = "pnlSidebar";
        lblLogo.Name = "lblLogo";
        lblBrand.Name = "lblBrand";
        lblBrandSub.Name = "lblBrandSub";
        lblNav.Name = "lblNav";
        pnlDivider.Name = "pnlDivider";
        lblDatabase.Name = "lblDatabase";
        lblProvider.Name = "lblProvider";
        lblConnection.Name = "lblConnection";
        pnlContent.Name = "pnlContent";
        pnlHeader.Name = "pnlHeader";
        lblEyebrow.Name = "lblEyebrow";
        lblTitle.Name = "lblTitle";
        lblSubtitle.Name = "lblSubtitle";
        lblCount.Name = "lblCount";
        pnlSearch.Name = "pnlSearch";
        lblSearch.Name = "lblSearch";
        txtBuscar.Name = "txtBuscar";
        btnBuscar.Name = "btnBuscar";
        btnActualizar.Name = "btnActualizar";
        pnlActions.Name = "pnlActions";
        btnNuevo.Name = "btnNuevo";
        btnEditar.Name = "btnEditar";
        btnEliminar.Name = "btnEliminar";
        pnlGrid.Name = "pnlGrid";
        dgvPeople.Name = "dgvPeople";
        lblEmpty.Name = "lblEmpty";
        pnlStatus.Name = "pnlStatus";
        lblStatus.Name = "lblStatus";
        // pnlSidebar
        pnlSidebar.Dock = DockStyle.Left;
        pnlSidebar.Width = 216;
        pnlSidebar.BackColor = Color.FromArgb(15, 23, 42);
        pnlSidebar.Size = new Size(216, 740);
        // lblLogo
        lblLogo.Text = "P";
        lblLogo.Location = new Point(24, 32);
        lblLogo.Size = new Size(42, 42);
        lblLogo.ForeColor = Color.White;
        lblLogo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblLogo.AutoEllipsis = true;
        lblLogo.BackColor = Color.FromArgb(13, 148, 136);
        lblLogo.TextAlign = ContentAlignment.MiddleCenter;
        // lblBrand
        lblBrand.Text = "Personas";
        lblBrand.Location = new Point(78, 36);
        lblBrand.Size = new Size(124, 32);
        lblBrand.ForeColor = Color.White;
        lblBrand.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
        lblBrand.AutoEllipsis = true;
        // lblBrandSub
        lblBrandSub.Text = "GESTIÓN DE REGISTROS";
        lblBrandSub.Location = new Point(24, 100);
        lblBrandSub.Size = new Size(176, 22);
        lblBrandSub.ForeColor = Color.FromArgb(148, 163, 184);
        lblBrandSub.Font = new Font("Segoe UI", 8F, FontStyle.Regular);
        lblBrandSub.AutoEllipsis = true;
        // lblNav
        lblNav.Text = "   Directorio";
        lblNav.Location = new Point(16, 164);
        lblNav.Size = new Size(184, 50);
        lblNav.ForeColor = Color.White;
        lblNav.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblNav.AutoEllipsis = true;
        lblNav.BackColor = Color.FromArgb(30, 55, 69);
        lblNav.TextAlign = ContentAlignment.MiddleLeft;
        // pnlDivider
        pnlDivider.Location = new Point(24, 594);
        pnlDivider.Size = new Size(168, 1);
        pnlDivider.BackColor = Color.FromArgb(51, 65, 85);
        pnlDivider.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        // lblDatabase
        lblDatabase.Text = "BASE DE DATOS";
        lblDatabase.Location = new Point(24, 614);
        lblDatabase.Size = new Size(168, 22);
        lblDatabase.ForeColor = Color.FromArgb(148, 163, 184);
        lblDatabase.Font = new Font("Segoe UI", 8F, FontStyle.Regular);
        lblDatabase.AutoEllipsis = true;
        // lblProvider
        lblProvider.Text = "PostgreSQL";
        lblProvider.Location = new Point(24, 640);
        lblProvider.Size = new Size(168, 24);
        lblProvider.ForeColor = Color.White;
        lblProvider.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblProvider.AutoEllipsis = true;
        // lblConnection
        lblConnection.Text = "●  Pendiente";
        lblConnection.Location = new Point(24, 679);
        lblConnection.Size = new Size(174, 24);
        lblConnection.ForeColor = Color.FromArgb(253, 186, 116);
        lblConnection.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        lblConnection.AutoEllipsis = true;
        lblDatabase.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblProvider.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblConnection.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        pnlSidebar.Controls.Add(lblLogo);
        pnlSidebar.Controls.Add(lblBrand);
        pnlSidebar.Controls.Add(lblBrandSub);
        pnlSidebar.Controls.Add(lblNav);
        pnlSidebar.Controls.Add(pnlDivider);
        pnlSidebar.Controls.Add(lblDatabase);
        pnlSidebar.Controls.Add(lblProvider);
        pnlSidebar.Controls.Add(lblConnection);
        // pnlContent
        pnlContent.Dock = DockStyle.Fill;
        pnlContent.Padding = new Padding(30);
        pnlContent.BackColor = Color.FromArgb(244, 247, 251);
        pnlContent.Size = new Size(924, 740);
        // pnlHeader
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Height = 110;
        pnlHeader.Size = new Size(864, 110);
        // lblEyebrow
        lblEyebrow.Text = "DIRECTORIO";
        lblEyebrow.Location = new Point(0, 0);
        lblEyebrow.Size = new Size(300, 20);
        lblEyebrow.ForeColor = Color.FromArgb(13, 148, 136);
        lblEyebrow.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        lblEyebrow.AutoEllipsis = true;
        // lblTitle
        lblTitle.Text = "Directorio de personas";
        lblTitle.Location = new Point(0, 25);
        lblTitle.Size = new Size(584, 40);
        lblTitle.ForeColor = Color.FromArgb(30, 41, 59);
        lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblTitle.AutoEllipsis = true;
        // lblSubtitle
        lblSubtitle.Text = "Consulte y mantenga actualizados sus registros.";
        lblSubtitle.Location = new Point(0, 75);
        lblSubtitle.Size = new Size(584, 26);
        lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
        lblSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        lblSubtitle.AutoEllipsis = true;
        // lblCount
        lblCount.Text = "Sin cargar";
        lblCount.Location = new Point(702, 29);
        lblCount.Size = new Size(162, 39);
        lblCount.ForeColor = Color.FromArgb(13, 148, 136);
        lblCount.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblCount.AutoEllipsis = true;
        lblCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblCount.TextAlign = ContentAlignment.MiddleRight;
        pnlHeader.Controls.Add(lblEyebrow);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblCount);
        // pnlSearch
        pnlSearch.Dock = DockStyle.Top;
        pnlSearch.Height = 76;
        pnlSearch.Size = new Size(864, 76);
        // lblSearch
        lblSearch.Text = "Buscar por nombre";
        lblSearch.Location = new Point(0, 0);
        lblSearch.Size = new Size(500, 22);
        lblSearch.ForeColor = Color.FromArgb(100, 116, 139);
        lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        lblSearch.AutoEllipsis = true;
        // txtBuscar
        txtBuscar.Location = new Point(0, 28);
        txtBuscar.Size = new Size(604, 31);
        txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
        txtBuscar.PlaceholderText = "Escriba un nombre...";
        txtBuscar.MaxLength = 100;
        txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtBuscar.TabIndex = 0;
        txtBuscar.KeyDown += txtBuscar_KeyDown;
        // btnBuscar
        btnBuscar.Text = "Buscar";
        btnBuscar.Location = new Point(616, 25);
        btnBuscar.Size = new Size(100, 38);
        btnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnBuscar.BackColor = Color.FromArgb(15, 23, 42);
        btnBuscar.ForeColor = Color.White;
        btnBuscar.FlatStyle = FlatStyle.Flat;
        btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(15, 23, 42);
        btnBuscar.FlatAppearance.BorderSize = 1;
        btnBuscar.Cursor = Cursors.Hand;
        btnBuscar.UseVisualStyleBackColor = false;
        btnBuscar.TabIndex = 0;
        // btnActualizar
        btnActualizar.Text = "Actualizar";
        btnActualizar.Location = new Point(728, 25);
        btnActualizar.Size = new Size(136, 38);
        btnActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnActualizar.BackColor = Color.White;
        btnActualizar.ForeColor = Color.FromArgb(30, 41, 59);
        btnActualizar.FlatStyle = FlatStyle.Flat;
        btnActualizar.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
        btnActualizar.FlatAppearance.BorderSize = 1;
        btnActualizar.Cursor = Cursors.Hand;
        btnActualizar.UseVisualStyleBackColor = false;
        btnActualizar.TabIndex = 0;
        btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnBuscar.Click += btnBuscar_Click;
        btnActualizar.Click += btnActualizar_Click;
        btnBuscar.TabIndex = 1;
        btnActualizar.TabIndex = 2;
        pnlSearch.Controls.Add(lblSearch);
        pnlSearch.Controls.Add(txtBuscar);
        pnlSearch.Controls.Add(btnBuscar);
        pnlSearch.Controls.Add(btnActualizar);
        // pnlActions
        pnlActions.Dock = DockStyle.Top;
        pnlActions.Height = 66;
        pnlActions.Size = new Size(864, 66);
        // btnNuevo
        btnNuevo.Text = "+  Nueva persona";
        btnNuevo.Location = new Point(0, 6);
        btnNuevo.Size = new Size(170, 42);
        btnNuevo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnNuevo.BackColor = Color.FromArgb(13, 148, 136);
        btnNuevo.ForeColor = Color.White;
        btnNuevo.FlatStyle = FlatStyle.Flat;
        btnNuevo.FlatAppearance.BorderColor = Color.FromArgb(13, 148, 136);
        btnNuevo.FlatAppearance.BorderSize = 1;
        btnNuevo.Cursor = Cursors.Hand;
        btnNuevo.UseVisualStyleBackColor = false;
        btnNuevo.TabIndex = 0;
        // btnEditar
        btnEditar.Text = "Editar";
        btnEditar.Location = new Point(182, 6);
        btnEditar.Size = new Size(100, 42);
        btnEditar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnEditar.BackColor = Color.White;
        btnEditar.ForeColor = Color.FromArgb(30, 41, 59);
        btnEditar.FlatStyle = FlatStyle.Flat;
        btnEditar.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
        btnEditar.FlatAppearance.BorderSize = 1;
        btnEditar.Cursor = Cursors.Hand;
        btnEditar.UseVisualStyleBackColor = false;
        btnEditar.TabIndex = 0;
        // btnEliminar
        btnEliminar.Text = "Eliminar";
        btnEliminar.Location = new Point(294, 6);
        btnEliminar.Size = new Size(110, 42);
        btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnEliminar.BackColor = Color.FromArgb(255, 241, 242);
        btnEliminar.ForeColor = Color.FromArgb(190, 18, 60);
        btnEliminar.FlatStyle = FlatStyle.Flat;
        btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(254, 205, 211);
        btnEliminar.FlatAppearance.BorderSize = 1;
        btnEliminar.Cursor = Cursors.Hand;
        btnEliminar.UseVisualStyleBackColor = false;
        btnEliminar.TabIndex = 0;
        btnNuevo.TabIndex = 3;
        btnEditar.TabIndex = 4;
        btnEliminar.TabIndex = 5;
        btnEditar.Enabled = false;
        btnEliminar.Enabled = false;
        btnNuevo.Click += btnNuevo_Click;
        btnEditar.Click += btnEditar_Click;
        btnEliminar.Click += btnEliminar_Click;
        pnlActions.Controls.Add(btnNuevo);
        pnlActions.Controls.Add(btnEditar);
        pnlActions.Controls.Add(btnEliminar);
        // pnlGrid
        pnlGrid.Dock = DockStyle.Fill;
        pnlGrid.Padding = new Padding(1);
        pnlGrid.BackColor = Color.FromArgb(226, 232, 240);
        pnlGrid.Size = new Size(864, 384);
        // dgvPeople
        dgvPeople.Dock = DockStyle.Fill;
        dgvPeople.BackgroundColor = Color.White;
        dgvPeople.BorderStyle = BorderStyle.None;
        dgvPeople.AutoGenerateColumns = false;
        dgvPeople.AllowUserToAddRows = false;
        dgvPeople.AllowUserToDeleteRows = false;
        dgvPeople.AllowUserToResizeRows = false;
        dgvPeople.ReadOnly = true;
        dgvPeople.MultiSelect = false;
        dgvPeople.RowHeadersVisible = false;
        dgvPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvPeople.EnableHeadersVisualStyles = false;
        dgvPeople.ColumnHeadersHeight = 44;
        dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvPeople.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvPeople.GridColor = Color.FromArgb(241, 245, 249);
        dgvPeople.RowTemplate.Height = 46;
        dgvPeople.TabIndex = 6;
        dgvPeople.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.FromArgb(241, 245, 249), ForeColor = Color.FromArgb(71, 85, 105), Font = new Font("Segoe UI", 10F, FontStyle.Bold), Padding = new Padding(14, 0, 0, 0), SelectionBackColor = Color.FromArgb(241, 245, 249), SelectionForeColor = Color.FromArgb(71, 85, 105) };
        dgvPeople.DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.White, ForeColor = Color.FromArgb(30, 41, 59), Font = new Font("Segoe UI", 11F), Padding = new Padding(14, 0, 0, 0), SelectionBackColor = Color.FromArgb(204, 251, 241), SelectionForeColor = Color.FromArgb(17, 94, 89) };
        dgvPeople.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.FromArgb(249, 251, 253) };
        // colId
        colId.Name = "colId";
        colId.DataPropertyName = "Id";
        colId.HeaderText = "ID";
        colId.FillWeight = 16F;
        colId.ReadOnly = true;
        colId.SortMode = DataGridViewColumnSortMode.NotSortable;
        // colName
        colName.Name = "colName";
        colName.DataPropertyName = "Name";
        colName.HeaderText = "Nombre";
        colName.FillWeight = 64F;
        colName.ReadOnly = true;
        colName.SortMode = DataGridViewColumnSortMode.NotSortable;
        // colAge
        colAge.Name = "colAge";
        colAge.DataPropertyName = "Age";
        colAge.HeaderText = "Edad";
        colAge.FillWeight = 20F;
        colAge.ReadOnly = true;
        colAge.SortMode = DataGridViewColumnSortMode.NotSortable;
        dgvPeople.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colAge });
        dgvPeople.SelectionChanged += dgvPeople_SelectionChanged;
        dgvPeople.CellDoubleClick += dgvPeople_CellDoubleClick;
        // lblEmpty
        lblEmpty.Text = "No hay registros para mostrar.";
        lblEmpty.Location = new Point(170, 120);
        lblEmpty.Size = new Size(460, 46);
        lblEmpty.ForeColor = Color.FromArgb(100, 116, 139);
        lblEmpty.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
        lblEmpty.AutoEllipsis = true;
        lblEmpty.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblEmpty.BackColor = Color.White;
        lblEmpty.TextAlign = ContentAlignment.MiddleCenter;
        pnlGrid.Controls.Add(dgvPeople);
        pnlGrid.Controls.Add(lblEmpty);
        lblEmpty.BringToFront();
        // pnlStatus
        pnlStatus.Dock = DockStyle.Bottom;
        pnlStatus.Height = 44;
        pnlStatus.Size = new Size(864, 44);
        // lblStatus
        lblStatus.Text = "Preparando el directorio...";
        lblStatus.Location = new Point(0, 17);
        lblStatus.Size = new Size(864, 24);
        lblStatus.ForeColor = Color.FromArgb(100, 116, 139);
        lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        lblStatus.AutoEllipsis = true;
        lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pnlStatus.Controls.Add(lblStatus);
        pnlContent.Controls.Add(pnlGrid);
        pnlContent.Controls.Add(pnlActions);
        pnlContent.Controls.Add(pnlSearch);
        pnlContent.Controls.Add(pnlHeader);
        pnlContent.Controls.Add(pnlStatus);
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1140, 740);
        MinimumSize = new Size(1040, 720);
        Font = new Font("Segoe UI", 9F);
        Text = "Personas | PostgreSQL";
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Controls.Add(pnlContent);
        Controls.Add(pnlSidebar);
        Load += Form1_Load;
        FormClosing += Form1_FormClosing;
        ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
        pnlStatus.ResumeLayout(false);
        pnlStatus.PerformLayout();
        pnlGrid.ResumeLayout(false);
        pnlGrid.PerformLayout();
        pnlActions.ResumeLayout(false);
        pnlActions.PerformLayout();
        pnlSearch.ResumeLayout(false);
        pnlSearch.PerformLayout();
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlContent.ResumeLayout(false);
        pnlContent.PerformLayout();
        pnlDivider.ResumeLayout(false);
        pnlDivider.PerformLayout();
        pnlSidebar.ResumeLayout(false);
        pnlSidebar.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
    #endregion

    private Panel pnlSidebar = null!;
    private Label lblLogo = null!;
    private Label lblBrand = null!;
    private Label lblBrandSub = null!;
    private Label lblNav = null!;
    private Panel pnlDivider = null!;
    private Label lblDatabase = null!;
    private Label lblProvider = null!;
    private Label lblConnection = null!;
    private Panel pnlContent = null!;
    private Panel pnlHeader = null!;
    private Label lblEyebrow = null!;
    private Label lblTitle = null!;
    private Label lblSubtitle = null!;
    private Label lblCount = null!;
    private Panel pnlSearch = null!;
    private Label lblSearch = null!;
    private TextBox txtBuscar = null!;
    private Button btnBuscar = null!;
    private Button btnActualizar = null!;
    private Panel pnlActions = null!;
    private Button btnNuevo = null!;
    private Button btnEditar = null!;
    private Button btnEliminar = null!;
    private Panel pnlGrid = null!;
    private DataGridView dgvPeople = null!;
    private DataGridViewTextBoxColumn colId = null!;
    private DataGridViewTextBoxColumn colName = null!;
    private DataGridViewTextBoxColumn colAge = null!;
    private Label lblEmpty = null!;
    private Panel pnlStatus = null!;
    private Label lblStatus = null!;
}
