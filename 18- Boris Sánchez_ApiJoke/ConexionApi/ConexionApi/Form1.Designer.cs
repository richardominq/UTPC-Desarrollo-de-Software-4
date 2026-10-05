namespace ConexionApi
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            btnObtener = new Button();
            txtChiste = new TextBox();
            groupBox1 = new GroupBox();
            btnGuardarJSON = new Button();
            btnGuardarCSV = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Location = new Point(261, 53);
            label1.Name = "label1";
            label1.Size = new Size(252, 20);
            label1.TabIndex = 0;
            label1.Text = "JOKE API - GENERADOR DE CHISTES";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(91, 94);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 1;
            label2.Text = "Chiste Obtenido";
            label2.Click += label2_Click;
            // 
            // btnObtener
            // 
            btnObtener.BackColor = SystemColors.ActiveCaption;
            btnObtener.Location = new Point(91, 226);
            btnObtener.Name = "btnObtener";
            btnObtener.Size = new Size(202, 29);
            btnObtener.TabIndex = 3;
            btnObtener.Text = "Obtener Chiste";
            btnObtener.UseVisualStyleBackColor = false;
            btnObtener.Click += btnObtener_Click;
            // 
            // txtChiste
            // 
            txtChiste.Location = new Point(91, 122);
            txtChiste.Multiline = true;
            txtChiste.Name = "txtChiste";
            txtChiste.ReadOnly = true;
            txtChiste.ScrollBars = ScrollBars.Vertical;
            txtChiste.Size = new Size(438, 98);
            txtChiste.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardarJSON);
            groupBox1.Controls.Add(btnGuardarCSV);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(89, 306);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(585, 132);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "GUARDAR CHISTE";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnGuardarJSON
            // 
            btnGuardarJSON.BackColor = SystemColors.AppWorkspace;
            btnGuardarJSON.Location = new Point(301, 66);
            btnGuardarJSON.Name = "btnGuardarJSON";
            btnGuardarJSON.Size = new Size(137, 60);
            btnGuardarJSON.TabIndex = 1;
            btnGuardarJSON.Text = "GUARDAR JSON";
            btnGuardarJSON.UseVisualStyleBackColor = false;
            btnGuardarJSON.Click += btnGuardarJSON_Click;
            // 
            // btnGuardarCSV
            // 
            btnGuardarCSV.BackColor = SystemColors.MenuHighlight;
            btnGuardarCSV.Location = new Point(61, 66);
            btnGuardarCSV.Name = "btnGuardarCSV";
            btnGuardarCSV.Size = new Size(139, 60);
            btnGuardarCSV.TabIndex = 0;
            btnGuardarCSV.Text = "GUARDAR CSV";
            btnGuardarCSV.UseVisualStyleBackColor = false;
            btnGuardarCSV.Click += btnGuardarCSV_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(txtChiste);
            Controls.Add(btnObtener);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnObtener;
        private TextBox txtChiste;
        private GroupBox groupBox1;
        private Button btnGuardarCSV;
        private Button btnGuardarJSON;
    }
}
