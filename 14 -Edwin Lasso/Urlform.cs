using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace ActividadListView
{
    public partial class UrlForm : Form
    {
        public string Url
        {
            get
            {
                return txtUrl.Text.Trim();
            }
        }

        public UrlForm()
        {
            InitializeComponent();

            AcceptButton = btnCargar;
            CancelButton = btnCancelar;
        }
        private async void btnCargar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrl.Text))
            {
                MessageBox.Show(
                    "Introduce una URL.",
                    "URL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!Uri.TryCreate(
                    txtUrl.Text.Trim(),
                    UriKind.Absolute,
                    out Uri? uri) ||
                (uri.Scheme != Uri.UriSchemeHttp &&
                 uri.Scheme != Uri.UriSchemeHttps))
            {
                MessageBox.Show(
                    "La URL no es válida.",
                    "URL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
