using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ActividadListView
{

    public partial class EditRecordForm : Form

    {
        private readonly List<string> columns;
        private readonly List<string> values;
        private readonly List<TextBox> textBoxes = new();
        public EditRecordForm(
        List<string> columns,
        List<string> values)
        {
            InitializeComponent();

            this.columns = columns;
            this.values = values;

            CreateFields();
        }
        private void CreateFields()
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            // Limpiar lista de TextBox para evitar duplicados si se recrean los campos
            textBoxes.Clear();

            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.RowCount = columns.Count;

            for (int i = 0; i < columns.Count; i++)
            {
                tableLayoutPanel1.RowStyles.Add(
                    new RowStyle(
                        SizeType.AutoSize));

                Label label = new Label
                {
                    Text = columns[i],
                    AutoSize = true,
                    Anchor = AnchorStyles.Left,
                    Margin = new Padding(5)
                };

                TextBox textBox = new TextBox
                {
                    Text = i < values.Count
                        ? values[i]
                        : string.Empty,

                    Anchor = AnchorStyles.Left |
                             AnchorStyles.Right,

                    Margin = new Padding(5)
                };

                textBoxes.Add(textBox);

                tableLayoutPanel1.Controls.Add(label, 0, i);
                tableLayoutPanel1.Controls.Add(textBox, 1, i);
            }
        }

        public EditRecordForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


            private void btnAceptar_Click(object sender, EventArgs e)
        {
            values.Clear();

            foreach (TextBox textBox in textBoxes)
            {
                values.Add(textBox.Text);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

    }
}

