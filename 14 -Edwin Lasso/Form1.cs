using CsvJsonManager.Models;
using CsvJsonManager.Services;
using System.IO;
using System.Text.Json;

namespace ActividadListView
{
    public partial class MainForm : Form
    {
        private DataDocument? currentDocument;

        private readonly CsvService csvService = new CsvService();
        private readonly JsonService jsonService = new JsonService();

        public MainForm()
        {
            InitializeComponent();


        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter =
                "Archivos compatibles|*.csv;*.json|" +
                "Archivos CSV|*.csv|" +
                "Archivos JSON|*.json|" +
                "Todos los archivos|*.*";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string filePath = openFileDialog1.FileName;

            string extension = Path.GetExtension(filePath).ToLowerInvariant();

            try
            {
                if (extension == ".csv")
                {
                    currentDocument = csvService.Load(filePath);
                }
                else if (extension == ".json")
                {
                    currentDocument = jsonService.Load(filePath);
                }
                else
                {
                    MessageBox.Show(
                        "El formato del archivo no es compatible.",
                        "Formato no compatible",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DisplayDocument();

                lblEstado.Text =
                    $"Archivo: {currentDocument.FileName} | " +
                    $"Formato: {currentDocument.FileType} | " +
                    $"Registros: {currentDocument.Rows.Count}";

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo abrir el archivo.\n\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DisplayDocument()
        {
            if (currentDocument == null)
                return;

            lvDatos.BeginUpdate();

            try
            {
                lvDatos.Clear();

                foreach (string column in currentDocument.Columns)
                {
                    lvDatos.Columns.Add(column);
                }

                foreach (List<string> row in currentDocument.Rows)
                {
                    var item = new ListViewItem(
                        row.Count > 0 ? row[0] : string.Empty);

                    for (int i = 1; i < currentDocument.Columns.Count; i++)
                    {
                        string value = i < row.Count
                            ? row[i]
                            : string.Empty;

                        item.SubItems.Add(value);
                    }

                    lvDatos.Items.Add(item);
                }

                lvDatos.AutoResizeColumns(
                    ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            finally
            {
                lvDatos.EndUpdate();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (currentDocument == null)
            {
                MessageBox.Show(
                    "Primero debes abrir un archivo.",
                    "Editar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (lvDatos.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Selecciona un registro para editar.",
                    "Editar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int index = lvDatos.SelectedItems[0].Index;

            List<string> row = currentDocument.Rows[index];

            // Crear una copia que será editada por el formulario
            List<string> editedRow = new List<string>(row);

            using EditRecordForm form =
                new EditRecordForm(
                    currentDocument.Columns,
                    editedRow);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                // Reemplazar la fila por la versión editada
                currentDocument.Rows[index] = editedRow;

                DisplayDocument();

                lvDatos.Items[index].Selected = true;

                lblEstado.Text =
                    $"Archivo: {currentDocument.FileName} | " +
                    $"Formato: {currentDocument.FileType} | " +
                    $"Registros: {currentDocument.Rows.Count}";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (currentDocument == null)
            {
                MessageBox.Show(
                    "No hay ningún archivo abierto.",
                    "Guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            try
            {
                if (string.IsNullOrWhiteSpace(currentDocument.FilePath))
                {
                    GuardarComo();
                    return;
                }

                GuardarDocumento(currentDocument.FilePath);

                lblEstado.Text =
                    $"Guardado: {currentDocument.FileName} | " +
                    $"Registros: {currentDocument.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo guardar el archivo.\n\n{ex.Message}",
                    "Error al guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void GuardarDocumento(string filePath)
        {
            if (currentDocument == null)
                return;

            string extension =
                Path.GetExtension(filePath).ToLowerInvariant();

            if (extension == ".csv")
            {
                csvService.Save(currentDocument, filePath);
            }
            else if (extension == ".json")
            {
                jsonService.Save(currentDocument, filePath);
            }
            else
            {
                throw new Exception(
                    "El formato del archivo no es compatible.");
            }

            currentDocument.FilePath = filePath;
            currentDocument.FileName = Path.GetFileName(filePath);
            currentDocument.FileType =
                extension == ".csv" ? "CSV" : "JSON";
        }

        private void btnGuardarComo_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }
        private void GuardarComo()
        {
            if (currentDocument == null)
            {
                MessageBox.Show(
                    "No hay ningún documento para guardar.",
                    "Guardar como",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            saveFileDialog1.Filter =
                "Archivos CSV|*.csv|" +
                "Archivos JSON|*.json";

            saveFileDialog1.FileName =
                currentDocument.FileName;

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                GuardarDocumento(saveFileDialog1.FileName);

                lblEstado.Text =
                    $"Guardado: {currentDocument.FileName} | " +
                    $"Formato: {currentDocument.FileType} | " +
                    $"Registros: {currentDocument.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo guardar el archivo.\n\n{ex.Message}",
                    "Error al guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void cargarDesdeURLToolStripMenuItem_Click(
            object sender,
            EventArgs e)
        {
            using UrlForm form = new UrlForm();

            if (form.ShowDialog(this) != DialogResult.OK)
                return;

            string url = form.Url;

            try
            {
                Cursor = Cursors.WaitCursor;

                using var client = new HttpClient();

                // Evitar que una petición se quede esperando indefinidamente.
                client.Timeout = TimeSpan.FromSeconds(30);

                HttpResponseMessage response =
                    await client.GetAsync(url);

                // Comprobar código HTTP.
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(
                        $"La API respondió con el código HTTP " +
                        $"{(int)response.StatusCode} " +
                        $"({response.StatusCode}).");
                }

                string content =
                    await response.Content.ReadAsStringAsync();

                if (string.IsNullOrWhiteSpace(content))
                {
                    throw new Exception(
                        "La API no devolvió ningún contenido.");
                }

                // Crear el documento.
                var document = new DataDocument
                {
                    FilePath = "",
                    FileName = Path.GetFileName(
                        new Uri(url).AbsolutePath),
                    FileType = ""
                };

                if (string.IsNullOrWhiteSpace(document.FileName))
                {
                    document.FileName = "datos";
                }

                // Intentar determinar si el contenido es JSON.
                bool isJson = false;

                try
                {
                    using JsonDocument jsonDocument =
                        JsonDocument.Parse(content);

                    isJson = true;
                }
                catch (JsonException)
                {
                    isJson = false;
                }

                if (isJson)
                {
                    document.FileType = "JSON";

                    jsonService.LoadFromContent(
                        content,
                        document);
                }
                else
                {
                    // Si no es JSON, intentamos tratarlo como CSV.
                    document.FileType = "CSV";

                    csvService.LoadFromContent(
                        content,
                        document);

                    // Un CSV válido debe tener al menos una columna.
                    if (document.Columns.Count == 0)
                    {
                        throw new Exception(
                            "El contenido recibido no parece ser un " +
                            "archivo CSV o JSON válido.");
                    }
                }

                currentDocument = document;

                DisplayDocument();

                lblEstado.Text =
                    $"Archivo: {currentDocument.FileName} | " +
                    $"Formato: {currentDocument.FileType} | " +
                    $"Registros: {currentDocument.Rows.Count}";
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show(
                    "La conexión tardó demasiado o fue cancelada.",
                    "Tiempo de espera",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(
                    $"No se pudo conectar con la API.\n\n{ex.Message}",
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo descargar o procesar el contenido.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (currentDocument == null)
            {
                MessageBox.Show(
                    "Primero debes abrir un archivo.",
                    "Agregar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            // Crear una fila nueva con una celda vacía
            // por cada columna del documento.
            List<string> newRow =
                new List<string>();

            foreach (string column in currentDocument.Columns)
            {
                newRow.Add(string.Empty);
            }

            using EditRecordForm form =
                new EditRecordForm(
                    currentDocument.Columns,
                    newRow);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                // Agregar la nueva fila al documento.
                currentDocument.Rows.Add(newRow);

                DisplayDocument();

                // Seleccionar el registro recién agregado.
                if (lvDatos.Items.Count > 0)
                {
                    int index =
                        lvDatos.Items.Count - 1;

                    lvDatos.Items[index].Selected = true;
                    lvDatos.Items[index].EnsureVisible();
                }

                lblEstado.Text =
                    $"Archivo: {currentDocument.FileName} | " +
                    $"Formato: {currentDocument.FileType} | " +
                    $"Registros: {currentDocument.Rows.Count}";
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (currentDocument == null)
            {
                MessageBox.Show(
                    "Primero debes abrir un archivo.",
                    "Eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (lvDatos.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Selecciona un registro para eliminar.",
                    "Eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int index = lvDatos.SelectedItems[0].Index;

            DialogResult result = MessageBox.Show(
                "¿Seguro que deseas eliminar el registro seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            currentDocument.Rows.RemoveAt(index);

            DisplayDocument();

            lblEstado.Text =
                $"Archivo: {currentDocument.FileName} | " +
                $"Formato: {currentDocument.FileType} | " +
                $"Registros: {currentDocument.Rows.Count}";
        }

    }
}
