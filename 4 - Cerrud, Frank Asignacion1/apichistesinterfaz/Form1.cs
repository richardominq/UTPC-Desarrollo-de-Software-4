using System.Globalization;
using System.Text;
using System.Text.Json;

namespace apichistesinterfaz
{
    public partial class Form1 : Form
    {
        private readonly JokeService _servicio = new();
        private List<ChisteItem> _historial = new();

        private static readonly JsonSerializerOptions Opciones = new()
        {
            WriteIndented = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        public Form1()
        {
            InitializeComponent();
        }

        // GENERAR CHISTE
        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            try
            {
                AgregarMensaje("Tú", "Cuéntame un chiste");
                var chiste = await _servicio.ObtenerChisteEnEspanolAsync();
                AgregarMensaje("Bot", chiste);
                _historial.Add(new ChisteItem(DateTime.Now, chiste));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                button1.Enabled = true;
            }
        }

        // IMPORTAR JSON
        private void button2_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog { Filter = "JSON|*.json" };
            if (dlg.ShowDialog() != DialogResult.OK) return;

            try
            {
                var json = File.ReadAllText(dlg.FileName);
                _historial = JsonSerializer.Deserialize<List<ChisteItem>>(json) ?? new();

                richTextBox1.Clear();
                foreach (var c in _historial)
                    AgregarMensaje("Bot", c.Chiste);
            }
            catch (JsonException)
            {
                MessageBox.Show("El JSON no tiene un formato válido.");
            }
        }

        // EXPORTAR JSON
        private void button3_Click(object sender, EventArgs e)
        {
            if (_historial.Count == 0)
            {
                MessageBox.Show("Primero genera algún chiste.");
                return;
            }

            using var dlg = new SaveFileDialog { Filter = "JSON|*.json", FileName = "chistesparaexportar.json" };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, JsonSerializer.Serialize(_historial, Opciones));
                MessageBox.Show("Exportado correctamente.");
            }
        }

        private void AgregarMensaje(string quien, string texto)
            => richTextBox1.AppendText($"{quien}: {texto}{Environment.NewLine}{Environment.NewLine}");

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private const char Sep = ',';
        private void button4_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog { Filter = "CSV|*.csv" };
            if (dlg.ShowDialog() != DialogResult.OK) return;

            try
            {
                var filas = LeerCsv(File.ReadAllText(dlg.FileName, Encoding.UTF8));
                var lista = new List<ChisteItem>();

                foreach (var fila in filas)
                {
                    if (fila.Count < 2) continue;
                    if (fila[0].Trim().Equals("Fecha", StringComparison.OrdinalIgnoreCase)) continue; // encabezado
                    if (string.IsNullOrWhiteSpace(fila[1])) continue;

                    if (!DateTime.TryParse(fila[0], CultureInfo.InvariantCulture, DateTimeStyles.None, out var fecha))
                        fecha = DateTime.Now;

                    lista.Add(new ChisteItem(fecha, fila[1]));
                }

                if (lista.Count == 0)
                {
                    MessageBox.Show("El CSV no contiene chistes válidos.");
                    return;
                }

                _historial = lista;
                richTextBox1.Clear();
                foreach (var c in _historial)
                    AgregarMensaje("Bot", c.Chiste);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo leer el CSV: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_historial.Count == 0)
            {
                MessageBox.Show("Primero genera algún chiste.");
                return;
            }

            using var dlg = new SaveFileDialog { Filter = "CSV|*.csv", FileName = "chistes.csv" };
            if (dlg.ShowDialog() != DialogResult.OK) return;

            var sb = new StringBuilder();
            sb.AppendLine($"Fecha{Sep}Chiste");
            foreach (var c in _historial)
            {
                var fecha = c.Fecha.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                sb.AppendLine($"{fecha}{Sep}{EscaparCsv(c.Chiste)}");
            }

            // UTF-8 con BOM para que Excel muestre bien tildes y ñ
            File.WriteAllText(dlg.FileName, sb.ToString(), new UTF8Encoding(true));
            MessageBox.Show("Exportado correctamente.");
        }
        // Encierra el texto entre comillas si trae separador, comillas o saltos de línea
        private static string EscaparCsv(string texto)
        {
            texto ??= "";
            if (texto.Contains(Sep) || texto.Contains('"') || texto.Contains('\n') || texto.Contains('\r'))
                return "\"" + texto.Replace("\"", "\"\"") + "\"";
            return texto;
        }

        // Lector de CSV que respeta campos entre comillas (con comas y saltos de línea dentro)
        private static List<List<string>> LeerCsv(string texto)
        {
            var filas = new List<List<string>>();
            var fila = new List<string>();
            var campo = new StringBuilder();
            bool entreComillas = false;

            for (int i = 0; i < texto.Length; i++)
            {
                char ch = texto[i];

                if (entreComillas)
                {
                    if (ch == '"')
                    {
                        if (i + 1 < texto.Length && texto[i + 1] == '"') { campo.Append('"'); i++; }
                        else entreComillas = false;
                    }
                    else campo.Append(ch);
                }
                else if (ch == '"') entreComillas = true;
                else if (ch == Sep) { fila.Add(campo.ToString()); campo.Clear(); }
                else if (ch == '\r') { /* se ignora */ }
                else if (ch == '\n')
                {
                    fila.Add(campo.ToString()); campo.Clear();
                    filas.Add(fila); fila = new List<string>();
                }
                else campo.Append(ch);
            }

            if (campo.Length > 0 || fila.Count > 0)
            {
                fila.Add(campo.ToString());
                filas.Add(fila);
            }
            return filas;
        }
    }
}