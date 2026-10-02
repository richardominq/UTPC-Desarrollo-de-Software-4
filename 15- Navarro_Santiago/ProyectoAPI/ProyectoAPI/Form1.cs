using System;
using System.IO;  // Permite trabajar con archivos (guardar TXT, JSON y CSV)
using System.Net.Http; // Permite conectarse a una API mediante HTTP
using System.Text.Json; // Permite convertir JSON a objetos 
using System.Windows.Forms;

namespace ProyectoAPI
{
    public partial class Form1 : Form
    {
        // URL de la API JokeAPI.
        string url = "https://v2.jokeapi.dev/joke/Programming?lang=es";
        // almacenar el chiste obtenido de la API
        Chiste[,,] chistes = new Chiste[2, 3, 2];
        int cantidadChistes = 0;
        // HttpClient se utiliza para realizar la conexión con la API
        private static readonly HttpClient cliente = new HttpClient();

        public Form1()  // Constructor del formulario.
        {
            InitializeComponent();
            rdbJson.Checked = true;// Selecciona JSON como formato de guardado 

            txtChiste.ReadOnly = true; // Evita que el usuario pueda escribir manualmente el chiste
            txtResultadoEstado.ReadOnly = true; // Evita que el usuario pueda modificar el mensaje de estado

            txtResultadoEstado.Text = "Esperando...";
        }

        private void btnGuardar_Click(object sender, EventArgs e)  // BOTÓN GUARDAR
        {
            if (cantidadChistes == 0)            // Si no existe ningún chiste, no permite guardar
            {
                txtResultadoEstado.Text = "Primero obtén almenos un chiste.";
                return;
            }
            // pemite elegir donde guardar el archivo y su nombre
            using (SaveFileDialog guardar = new SaveFileDialog())
            {
                if (rdbJson.Checked) // Si el usuario seleccionó JSON
                {
                    guardar.Filter = "Archivo JSON|*.json";
                    guardar.FileName = "chiste.json";
                }
                else if (rdbTxt.Checked)// Si el usuario seleccionó TXT
                {
                    guardar.Filter = "Archivo de texto|*.txt";
                    guardar.FileName = "chiste.txt";
                }
                else if (rdbCsv.Checked) // Si el usuario seleccionó CSV
                {
                    guardar.Filter = "Archivo CSV|*.csv";
                    guardar.FileName = "chiste.csv";
                }

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (rdbJson.Checked) // Exportación de los chistes a JSON
                        {
                            string json = "[";
                            int guardados = 0;
                            // Recorre las tres dimensiones del arreglo
                            for (int d1 = 0; d1 <= chistes.GetUpperBound(0); d1++)
                            {
                                for (int d2 = 0; d2 <= chistes.GetUpperBound(1); d2++)
                                {
                                    for (int d3 = 0; d3 <= chistes.GetUpperBound(2); d3++)
                                    {
                                        Chiste? chiste = chistes[d1, d2, d3];

                                        if (chiste != null)
                                        {
                                            if (json != "[")
                                            {
                                                json += ",";
                                            }
                                            // Convierte el chiste a formato JSON
                                            json += JsonSerializer.Serialize(
                                                new
                                                {
                                                    Dimension1 = d1,
                                                    Dimension2 = d2,
                                                    Dimension3 = d3,
                                                    Tipo = chiste.type,
                                                    Joke = chiste.joke,
                                                    Setup = chiste.setup,
                                                    Delivery = chiste.delivery
                                                });

                                            guardados++;
                                        }
                                    }
                                }
                            }

                            json += "]";

                            File.WriteAllText(guardar.FileName,json); // Escribe el chsite en pantalla

                            txtResultadoEstado.Text = guardados + " chistes guardados correctamente en JSON";
                        }
                        else if (rdbTxt.Checked)// Exportación de los chistes a TXT
                        {
                            string texto = "";

                            for (int d1 = 0; d1 <= chistes.GetUpperBound(0); d1++) // Recorre las tres dimensiones del arreglo
                            {
                                for (int d2 = 0; d2 <= chistes.GetUpperBound(1); d2++)
                                {
                                    for (int d3 = 0; d3 <= chistes.GetUpperBound(2); d3++)
                                    {
                                        Chiste? chiste = chistes[d1, d2, d3];

                                        if (chiste != null)
                                        {
                                            texto +=
                                                "Dimensión 1: " + d1 + "\r\n" +
                                                "Dimensión 2: " + d2 + "\r\n" +
                                                "Dimensión 3: " + d3 + "\r\n" +
                                                "Tipo: " + chiste.type + "\r\n";

                                            if (chiste.type == "single")
                                            {
                                                texto +=
                                                    "Chiste: " +
                                                    chiste.joke +
                                                    "\r\n";
                                            }
                                            else
                                            {
                                                texto +=
                                                    "Pregunta: " +
                                                    chiste.setup +
                                                    "\r\n" +
                                                    "Respuesta: " +
                                                    chiste.delivery +
                                                    "\r\n";
                                            }

                                            texto += "--------------------------------\r\n";
                                        }
                                    }
                                }
                            }

                            File.WriteAllText(guardar.FileName,texto); // Escribe el contenido en el archivo TXT

                            txtResultadoEstado.Text =cantidadChistes +
                                " chistes guardados correctamente en TXT.";
                        }
                        else if (rdbCsv.Checked) // Exportación de los chistes a CSV
                        {
                            string csv = "Dimension1;Dimension2;Dimension3;Tipo;Chiste\r\n";

                            for (int d1 = 0; d1 <= chistes.GetUpperBound(0); d1++)
                            {
                                for (int d2 = 0; d2 <= chistes.GetUpperBound(1); d2++)
                                {
                                    for (int d3 = 0; d3 <= chistes.GetUpperBound(2); d3++)
                                    {
                                        Chiste? chiste = chistes[d1, d2, d3];

                                        if (chiste != null)
                                        {
                                            string textoChiste;

                                            if (chiste.type == "single")
                                            {
                                                textoChiste =
                                                    chiste.joke ?? "";
                                            }
                                            else
                                            {
                                                textoChiste =
                                                    (chiste.setup ?? "") +
                                                    " " +
                                                    (chiste.delivery ?? "");
                                            }

                                            textoChiste = // Ajusta la dorma en que organizara el archivo
                                                textoChiste.Replace(
                                                    "\"",
                                                    "\"\"");

                                            csv +=
                                                d1 + ";" +
                                                d2 + ";" +
                                                d3 + ";" +
                                                chiste.type + ";\"" +
                                                textoChiste +
                                                "\"\r\n";
                                        }
                                    }
                                }
                            }

                            File.WriteAllText(guardar.FileName,csv,new System.Text.UTF8Encoding(true));// Escribe el contenido en el archivo CSV

                            txtResultadoEstado.Text = cantidadChistes +
                                " chistes guardados correctamente en CSV.";
                        }
                    }
                    catch (Exception ex)
                    {
                        txtResultadoEstado.Text = "Error al guardar: " + ex.Message;
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) // Boton limpiar
        {
            for (int d1 = 0; d1 <= chistes.GetUpperBound(0); d1++)
            {
                for (int d2 = 0; d2 <= chistes.GetUpperBound(1); d2++)
                {
                    for (int d3 = 0; d3 <= chistes.GetUpperBound(2); d3++)
                    {
                        chistes[d1, d2, d3] = null;
                    }
                }
            }

            cantidadChistes = 0;

            txtChiste.Clear();

            txtResultadoEstado.Text = "Todos los chistes fueron eliminados";
            rdbJson.Checked = true;
        }

        private async void btnObtenerChiste_Click(object sender, EventArgs e) //boton qu permite obtener el chiste de la API
        {
            try
            {
                if (cantidadChistes >= 12) // conectar con la API, obtiene un chiste y  almacenar
                {
                    txtResultadoEstado.Text = "El arreglo está lleno. Máximo 12 chistes";
                    return;
                }

                txtResultadoEstado.Text ="Consultando API...";

                txtChiste.Clear();

                string respuesta = await cliente.GetStringAsync(url);// Realiza una petición HTTP a JokeAPI

                Chiste? nuevoChiste = JsonSerializer.Deserialize<Chiste>(respuesta);

                if (nuevoChiste == null)
                {
                    txtResultadoEstado.Text ="No se pudo procesar la respuesta de la API";
                    return;
                }

                int posicionD1 = 0;
                int posicionD2 = 0;
                int posicionD3 = 0;

                bool encontrado = false;

                for (int d1 = 0; d1 <= chistes.GetUpperBound(0); d1++) // Busca la primera posición disponible en el arreglo
                {
                    for (int d2 = 0; d2 <= chistes.GetUpperBound(1); d2++)
                    {
                        for (int d3 = 0; d3 <= chistes.GetUpperBound(2); d3++)
                        {
                            if (chistes[d1, d2, d3] == null)
                            {
                                posicionD1 = d1;
                                posicionD2 = d2;
                                posicionD3 = d3;

                                encontrado = true;
                                break;
                            }
                        }

                        if (encontrado)
                            break;
                    }

                    if (encontrado)
                        break;
                }

                chistes[ // almacenar el chiste segun su posicion
                    posicionD1,
                    posicionD2,
                    posicionD3
                ] = nuevoChiste;

                cantidadChistes++;

                if (nuevoChiste.type == "single")//mustra el chiste segun el formato recibido
                {
                    txtChiste.Text =nuevoChiste.joke;
                }
                else if (nuevoChiste.type == "twopart")
                {
                    txtChiste.Text =
                        nuevoChiste.setup +
                        "\r\n\r\n" +
                        nuevoChiste.delivery;
                }
                else
                {
                    txtChiste.Text = "La API devolvió un formato desconocido";
                }

                txtResultadoEstado.Text =
                    "Chiste almacenado correctamente" +
                    "\r\nPosición: [" +
                    posicionD1 + "," +
                    posicionD2 + "," +
                    posicionD3 + "]" +
                    "\r\nTotal almacenados: " +
                    cantidadChistes + "/12";
            }
            catch (HttpRequestException)
            {
                txtResultadoEstado.Text = "Error de conexión con la API";
            }
            catch (JsonException)
            {
                txtResultadoEstado.Text = "Error al procesar la respuesta de la API";
            }
            catch (Exception ex)
            {
                txtResultadoEstado.Text = "Error: " + ex.Message;
            }
        }

    }
    //Clase para la informcion recibida
    public class Chiste
    {
        public string? type { get; set; } //segun el tipo de chista
        public string? joke { get; set; } // Contiene el texto de un chiste de una sola parte
        public string? setup { get; set; } // Contiene la primera parte de un chiste de dos partes
        public string? delivery { get; set; } // Contiene la respuesta de un chiste de dos partes
    }
}