namespace ActividadListView
{
    partial class UrlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUrl = new TextBox();
            btnCargar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(12, 30);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(440, 23);
            txtUrl.TabIndex = 0;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(15, 67);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Aceptar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(105, 67);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 3;
            label1.Text = "Ingrese la URL ";
            label1.Click += label1_Click;
            // 
            // UrlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 107);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnCargar);
            Controls.Add(txtUrl);
            Name = "UrlForm";
            Text = "Cargar desde URL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrl;
        private Button btnCargar;
        private Button btnCancelar;
        private Label label1;
    }
}