namespace CrudWindowsForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel pnlTabla;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.Label lblEstado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pnlTabla = new System.Windows.Forms.Panel();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEstado = new System.Windows.Forms.Label();
            this.pnlEncabezado.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.pnlTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.SuspendLayout();
            // Encabezado
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(30, 64, 125);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Height = 106;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(26, 19);
            this.lblTitulo.Text = "Administración de personas";
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(222, 233, 250);
            this.lblSubtitulo.Location = new System.Drawing.Point(30, 68);
            this.lblSubtitulo.Text = "Consulte, agregue y mantenga actualizados sus registros.";
            // Acciones
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnActualizar);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAcciones.Height = 82;
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(21, 115, 71);
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(28, 20);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(126, 42);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(37, 86, 168);
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(166, 20);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(126, 42);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(183, 42, 51);
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(304, 20);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(126, 42);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "E&liminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(160, 178, 199);
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(30, 64, 125);
            this.btnActualizar.Location = new System.Drawing.Point(746, 20);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(126, 42);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            this.pnlAcciones.Size = new System.Drawing.Size(900, 82);
            // Tabla
            this.pnlTabla.Controls.Add(this.dgvPeople);
            this.pnlTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabla.Padding = new System.Windows.Forms.Padding(28, 0, 28, 8);
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AllowUserToResizeRows = false;
            this.dgvPeople.AutoGenerateColumns = false;
            this.dgvPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeople.BackgroundColor = System.Drawing.Color.White;
            this.dgvPeople.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPeople.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPeople.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPeople.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(227, 235, 247);
            this.dgvPeople.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(30, 64, 125);
            this.dgvPeople.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvPeople.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.dgvPeople.ColumnHeadersHeight = 44;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colId, this.colName, this.colAge });
            this.dgvPeople.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvPeople.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(35, 48, 68);
            this.dgvPeople.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(37, 86, 168);
            this.dgvPeople.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPeople.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.dgvPeople.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(246, 249, 253);
            this.dgvPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPeople.EnableHeadersVisualStyles = false;
            this.dgvPeople.GridColor = System.Drawing.Color.FromArgb(231, 237, 245);
            this.dgvPeople.MultiSelect = false;
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.RowHeadersVisible = false;
            this.dgvPeople.RowTemplate.Height = 40;
            this.dgvPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeople.TabIndex = 4;
            this.colId.DataPropertyName = "Id";
            this.colId.FillWeight = 16F;
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colName.DataPropertyName = "Name";
            this.colName.FillWeight = 64F;
            this.colName.HeaderText = "Nombre";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colAge.DataPropertyName = "Age";
            this.colAge.FillWeight = 20F;
            this.colAge.HeaderText = "Edad";
            this.colAge.Name = "colAge";
            this.colAge.ReadOnly = true;
            // Estado
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblEstado.Height = 48;
            this.lblEstado.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEstado.Text = "Cargando personas...";
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 250);
            this.ClientSize = new System.Drawing.Size(900, 590);
            this.Controls.Add(this.pnlTabla);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(740, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de personas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlAcciones.ResumeLayout(false);
            this.pnlTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
