namespace ActividadListView
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            btnNuevo = new ToolStripSplitButton();
            btnAgregar = new ToolStripMenuItem();
            btnEditar = new ToolStripMenuItem();
            btnEliminar = new ToolStripMenuItem();
            cargarDesdeURLToolStripMenuItem = new ToolStripMenuItem();
            btnAbrir = new ToolStripButton();
            btnGuardar = new ToolStripButton();
            btnGuardarComo = new ToolStripButton();
            lvDatos = new ListView();
            statusStrip1 = new StatusStrip();
            lblEstado = new ToolStripStatusLabel();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            toolTip1 = new ToolTip(components);
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnAbrir, btnGuardar, btnGuardarComo });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(885, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            btnNuevo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnNuevo.DropDownItems.AddRange(new ToolStripItem[] { btnAgregar, btnEditar, btnEliminar, cargarDesdeURLToolStripMenuItem });
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageTransparentColor = Color.Magenta;
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(71, 24);
            btnNuevo.Text = "Nuevo";
            // 
            // btnAgregar
            // 
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(224, 26);
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(224, 26);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(224, 26);
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cargarDesdeURLToolStripMenuItem
            // 
            cargarDesdeURLToolStripMenuItem.Name = "cargarDesdeURLToolStripMenuItem";
            cargarDesdeURLToolStripMenuItem.Size = new Size(224, 26);
            cargarDesdeURLToolStripMenuItem.Text = "Cargar desde URL";
            cargarDesdeURLToolStripMenuItem.Click += cargarDesdeURLToolStripMenuItem_Click;
            // 
            // btnAbrir
            // 
            btnAbrir.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAbrir.Image = (Image)resources.GetObject("btnAbrir.Image");
            btnAbrir.ImageTransparentColor = Color.Magenta;
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(46, 24);
            btnAbrir.Text = "Abrir";
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageTransparentColor = Color.Magenta;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(66, 24);
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnGuardarComo
            // 
            btnGuardarComo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnGuardarComo.Image = (Image)resources.GetObject("btnGuardarComo.Image");
            btnGuardarComo.ImageTransparentColor = Color.Magenta;
            btnGuardarComo.Name = "btnGuardarComo";
            btnGuardarComo.Size = new Size(110, 24);
            btnGuardarComo.Text = "Guardar Como";
            btnGuardarComo.Click += btnGuardarComo_Click;
            // 
            // lvDatos
            // 
            lvDatos.Dock = DockStyle.Fill;
            lvDatos.FullRowSelect = true;
            lvDatos.GridLines = true;
            lvDatos.Location = new Point(0, 27);
            lvDatos.MultiSelect = false;
            lvDatos.Name = "lvDatos";
            lvDatos.Size = new Size(885, 534);
            lvDatos.TabIndex = 2;
            lvDatos.UseCompatibleStateImageBehavior = false;
            lvDatos.View = View.Details;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblEstado });
            statusStrip1.Location = new Point(0, 535);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(885, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(40, 20);
            lblEstado.Text = "Listo";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Archivos compatibles|*.csv;*.json|Archivos CSV|*.csv|Archivos JSON|*.json|Todos los archivos|*.*";
            openFileDialog1.Title = "Abrir archivo";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Archivos CSV|*.csv|Archivos JSON|*.json|Todos los archivos|*.*";
            saveFileDialog1.Title = "Guardar archivo";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 561);
            Controls.Add(statusStrip1);
            Controls.Add(lvDatos);
            Controls.Add(toolStrip1);
            MinimumSize = new Size(900, 598);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CSV & JSON Manager";
            WindowState = FormWindowState.Minimized;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ListView lvDatos;
        private StatusStrip statusStrip1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripButton btnGuardarComo;
        private ToolStripSplitButton btnNuevo;
        private ToolStripMenuItem btnAgregar;
        private ToolStripMenuItem btnEditar;
        private ToolStripMenuItem btnEliminar;
        private ToolStripButton btnAbrir;
        private ToolStripButton btnGuardar;
        private ToolStripStatusLabel lblEstado;
        private ToolTip toolTip1;
        private ToolStripMenuItem cargarDesdeURLToolStripMenuItem;
    }
}
