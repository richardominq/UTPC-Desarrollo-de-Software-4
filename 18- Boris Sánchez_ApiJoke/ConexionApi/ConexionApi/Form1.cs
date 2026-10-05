using System.Net.Http;
using System.Text.Json;
using System.IO;
using System.Text;

namespace ConexionApi
{

    public partial class Form1 : Form
    {
        private readonly HttpClient cliente = new HttpClient();
        private ChisteApi chisteActual;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void btnObtener_Click(object sender, EventArgs e)
        {

            try
            {
                string url = "https://v2.jokeapi.dev/joke/Any?lang=es&safe-mode";

                string respuesta = await cliente.GetStringAsync(url);

                chisteActual = JsonSerializer.Deserialize<ChisteApi>(respuesta);

                if (chisteActual == null || chisteActual.error)
                {
                    MessageBox.Show("No se pudo obtener el chiste.");
                    return;
                }

                if (chisteActual.type == "single")
                {
                    txtChiste.Text = chisteActual.joke;
                }
                else
                {
                    txtChiste.Text = chisteActual.setup
                                   + Environment.NewLine
                                   + Environment.NewLine
                                   + chisteActual.delivery;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al obtener el chiste:\n\n"
                    + ex.Message
                );
            }
        }


        private void btnGuardarCSV_Click(object sender, EventArgs e)
        {
            if (chisteActual == null)
            {
                MessageBox.Show("Primero debes obtener un chiste.");
                return;
            }

            try
            {
                SaveFileDialog guardar = new SaveFileDialog();

                guardar.Filter = "Archivo CSV (*.csv)|*.csv";
                guardar.Title = "Guardar chiste como CSV";
                guardar.FileName = "chistes.csv";

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    bool archivoExiste = File.Exists(guardar.FileName);

                    using (StreamWriter escritor = new StreamWriter(
                        guardar.FileName,
                        true,
                        Encoding.UTF8))
                    {
                        if (!archivoExiste)
                        {
                            escritor.WriteLine("ID,Categoria,Tipo,Chiste");
                        }

                        string textoChiste;

                        if (chisteActual.type == "single")
                        {
                            textoChiste = chisteActual.joke;
                        }
                        else
                        {
                            textoChiste = chisteActual.setup
                                        + " - "
                                        + chisteActual.delivery;
                        }

                        textoChiste = textoChiste.Replace("\"", "\"\"");

                        escritor.WriteLine(
                            $"{chisteActual.id}," +
                            $"\"{chisteActual.category}\"," +
                            $"\"{chisteActual.type}\"," +
                            $"\"{textoChiste}\""
                        );
                    }

                    MessageBox.Show(
                        "El chiste se guardó correctamente."
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el archivo CSV:\n\n"
                    + ex.Message
                );
            }
        }


        private void btnGuardarJSON_Click(object sender, EventArgs e)
        {
            if (chisteActual == null)
            {
                MessageBox.Show("Primero debes obtener un chiste.");
                return;
            }

            try
            {
                SaveFileDialog guardar = new SaveFileDialog();

                guardar.Filter = "Archivo JSON (*.json)|*.json";
                guardar.Title = "Guardar chiste como JSON";
                guardar.FileName = "chiste.json";

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    string json = JsonSerializer.Serialize(
                        chisteActual,
                        new JsonSerializerOptions
                        {
                            WriteIndented = true
                        }
                    );

                    File.WriteAllText(
                        guardar.FileName,
                        json,
                        Encoding.UTF8
                    );

                    MessageBox.Show(
                        "El chiste se guardó correctamente en JSON."
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el archivo JSON:\n\n"
                    + ex.Message
                );
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}