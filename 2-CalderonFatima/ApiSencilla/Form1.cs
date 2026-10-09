using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace ApiSencilla;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    // Este evento se abre al hacer doble clic en el botón Consultar.
    private async void btnConsultar_Click(object sender, EventArgs e)
    {
        if (!Uri.TryCreate(txtUrl.Text.Trim(), UriKind.Absolute, out Uri? url)
            || (url.Scheme != "https" && url.Scheme != "http"))
        {
            MessageBox.Show("Escribe una URL válida que empiece con https:// o http://.");
            return;
        }

        btnConsultar.Enabled = false;
        lblEstado.Text = "Consultando la API...";
        try
        {
            using HttpClient cliente = new() { Timeout = TimeSpan.FromSeconds(20) };
            cliente.DefaultRequestHeaders.UserAgent.ParseAdd("ApiSencilla/1.0");
            string respuesta = await cliente.GetStringAsync(url);
            // Se indenta el JSON para que sea fácil de leer en la pantalla.
            using JsonDocument documento = JsonDocument.Parse(respuesta);
            if (IsDisposed) return;
            txtRespuesta.Text = JsonSerializer.Serialize(documento.RootElement,
                new JsonSerializerOptions { WriteIndented = true });
            lblEstado.Text = "Respuesta recibida. Puedes guardarla o copiarla.";
        }
        catch (Exception ex) when (ex is HttpRequestException or TaskCanceledException or JsonException)
        {
            if (IsDisposed) return;
            lblEstado.Text = "No se pudo consultar la API.";
            MessageBox.Show("Revisa la conexión y la URL. La API debe devolver JSON.\n\n" + ex.Message);
        }
        finally
        {
            if (!IsDisposed) btnConsultar.Enabled = true;
        }
    }

    private void btnAbrirJson_Click(object sender, EventArgs e)
    {
        using OpenFileDialog ventana = new() { Filter = "Archivos JSON (*.json)|*.json" };
        if (ventana.ShowDialog() != DialogResult.OK) return;
        try
        {
            string contenido = File.ReadAllText(ventana.FileName);
            using JsonDocument documento = JsonDocument.Parse(contenido);
            txtRespuesta.Text = JsonSerializer.Serialize(documento.RootElement,
                new JsonSerializerOptions { WriteIndented = true });
            lblEstado.Text = "Archivo abierto: " + Path.GetFileName(ventana.FileName);
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or JsonException)
        {
            MessageBox.Show("No se pudo abrir el archivo JSON.\n\n" + ex.Message);
        }
    }

    private void btnGuardarJson_Click(object sender, EventArgs e)
    {
        GuardarArchivo("json", "Archivos JSON (*.json)|*.json", txtRespuesta.Text);
    }

    private void btnGuardarTxt_Click(object sender, EventArgs e)
    {
        GuardarArchivo("txt", "Archivos de texto (*.txt)|*.txt", txtRespuesta.Text);
    }

    private void btnGuardarCsv_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtRespuesta.Text))
        {
            MessageBox.Show("Primero consulta una API o abre un JSON.");
            return;
        }
        // CSV sencillo: una columna con el nombre y otra con su valor JSON.
        using JsonDocument documento = JsonDocument.Parse(txtRespuesta.Text);
        var csv = new StringBuilder("Campo,Valor\r\n");
        if (documento.RootElement.ValueKind == JsonValueKind.Object)
        {
            foreach (JsonProperty campo in documento.RootElement.EnumerateObject())
                csv.AppendLine(CeldaCsv(campo.Name) + "," + CeldaCsv(campo.Value.ToString()));
        }
        else
            csv.AppendLine(CeldaCsv("datos") + "," + CeldaCsv(documento.RootElement.GetRawText()));
        GuardarArchivo("csv", "Archivos CSV (*.csv)|*.csv", csv.ToString());
    }

    private void btnCopiar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtRespuesta.Text)) return;
        try
        {
            Clipboard.SetText(txtRespuesta.Text);
            lblEstado.Text = "Contenido copiado.";
        }
        catch (System.Runtime.InteropServices.ExternalException)
        {
            MessageBox.Show("El portapapeles está ocupado. Inténtalo de nuevo.");
        }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        txtRespuesta.Clear();
        lblEstado.Text = "Listo para otra consulta.";
    }

    // Los tres botones de guardar comparten este pequeño método.
    private void GuardarArchivo(string extension, string filtro, string contenido)
    {
        if (string.IsNullOrWhiteSpace(contenido))
        {
            MessageBox.Show("Primero consulta una API o abre un JSON.");
            return;
        }
        using SaveFileDialog ventana = new()
        {
            Filter = filtro, DefaultExt = extension, AddExtension = true,
            FileName = "respuesta." + extension
        };
        if (ventana.ShowDialog() != DialogResult.OK) return;
        try
        {
            File.WriteAllText(ventana.FileName, contenido, new UTF8Encoding(extension == "csv"));
            lblEstado.Text = "Archivo guardado: " + Path.GetFileName(ventana.FileName);
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
        {
            MessageBox.Show("No se pudo guardar el archivo.\n\n" + ex.Message);
        }
    }

    private static string CeldaCsv(string texto)
    {
        if (texto.TrimStart().StartsWith('=') || texto.TrimStart().StartsWith('+')
            || texto.TrimStart().StartsWith('-') || texto.TrimStart().StartsWith('@'))
            texto = "'" + texto;
        return "\"" + texto.Replace("\"", "\"\"") + "\"";
    }
}
