using System.Text.Json;
using CsvJsonManager.Models;

namespace CsvJsonManager.Services
{
    public class JsonService
    {
        public DataDocument Load(string filePath)
        {
            var document = new DataDocument
            {
                FilePath = filePath,
                FileName = Path.GetFileName(filePath),
                FileType = "JSON"
            };

            string json = File.ReadAllText(filePath);

            LoadFromContent(json, document);

            return document;
        }

        // Cargar JSON desde Internet
        public async Task<DataDocument> LoadFromUrlAsync(string url)
        {
            using var client = new HttpClient();

            string content =
                await client.GetStringAsync(url);

            var uri = new Uri(url);

            string fileName =
                Path.GetFileName(uri.AbsolutePath);

            if (string.IsNullOrWhiteSpace(fileName))
                fileName = "datos.json";

            var document = new DataDocument
            {
                FilePath = "",
                FileName = fileName,
                FileType = "JSON"
            };

            LoadFromContent(content, document);

            return document;
        }

        // Procesar contenido JSON que ya tenemos en memoria
        public void LoadFromContent(
            string json,
            DataDocument document)
        {
            using JsonDocument jsonDocument =
                JsonDocument.Parse(json);

            JsonElement root =
                jsonDocument.RootElement;

            // Obtener el array que contiene los registros.
            JsonElement recordsArray =
                FindRecordsArray(root);

            if (recordsArray.ValueKind != JsonValueKind.Array)
            {
                throw new Exception(
                    "No se encontró un arreglo de objetos en el JSON.");
            }

            if (recordsArray.GetArrayLength() == 0)
                return;

            // El primer elemento debe ser un objeto.
            JsonElement firstObject =
                recordsArray[0];

            if (firstObject.ValueKind != JsonValueKind.Object)
            {
                throw new Exception(
                    "El arreglo JSON debe contener objetos.");
            }

            // Obtener las columnas del primer objeto.
            foreach (JsonProperty property
                in firstObject.EnumerateObject())
            {
                document.Columns.Add(property.Name);
            }

            // Leer todos los objetos.
            foreach (JsonElement item
                in recordsArray.EnumerateArray())
            {
                if (item.ValueKind != JsonValueKind.Object)
                    continue;

                var row = new List<string>();

                foreach (string column
                    in document.Columns)
                {
                    if (item.TryGetProperty(
                        column,
                        out JsonElement value))
                    {
                        row.Add(
                            GetValueAsString(value));
                    }
                    else
                    {
                        row.Add(string.Empty);
                    }
                }

                document.Rows.Add(row);
            }
        }

        private JsonElement FindRecordsArray(
            JsonElement root)
        {
            // Si el elemento actual ya es un array,
            // hemos encontrado los registros.
            if (root.ValueKind == JsonValueKind.Array)
            {
                return root;
            }

            // Si es un objeto, buscamos dentro de sus propiedades.
            if (root.ValueKind == JsonValueKind.Object)
            {
                // Primero buscamos propiedades que normalmente
                // suelen contener los registros.
                string[] preferredNames =
                {
            "data",
            "results",
            "items",
            "records",
            "users",
            "posts"
        };

                foreach (string name in preferredNames)
                {
                    if (root.TryGetProperty(
                        name,
                        out JsonElement value))
                    {
                        JsonElement result =
                            FindRecordsArray(value);

                        if (result.ValueKind == JsonValueKind.Array)
                        {
                            return result;
                        }
                    }
                }

                // Si no encontramos ninguna propiedad conocida,
                // buscamos recursivamente en todas las propiedades.
                foreach (JsonProperty property
                    in root.EnumerateObject())
                {
                    JsonElement result =
                        FindRecordsArray(property.Value);

                    if (result.ValueKind == JsonValueKind.Array)
                    {
                        return result;
                    }
                }
            }

            return default;
        }
        private string GetValueAsString(
            JsonElement value)
        {
            return value.ValueKind switch
            {
                JsonValueKind.String =>
                    value.GetString()
                    ?? string.Empty,

                JsonValueKind.Number =>
                    value.ToString(),

                JsonValueKind.True =>
                    "true",

                JsonValueKind.False =>
                    "false",

                JsonValueKind.Null =>
                    string.Empty,

                // Por ahora mantenemos los objetos
                // anidados como JSON dentro de una celda.
                JsonValueKind.Object =>
                    value.GetRawText(),

                // Los arrays también se mantienen
                // dentro de una sola celda.
                JsonValueKind.Array =>
                    value.GetRawText(),

                _ =>
                    value.ToString()
            };
        }

        public void Save(
            DataDocument document,
            string filePath)
        {
            var records =
                new List<Dictionary<string, string>>();

            foreach (List<string> row
                in document.Rows)
            {
                var record =
                    new Dictionary<string, string>();

                for (int i = 0;
                     i < document.Columns.Count;
                     i++)
                {
                    string value =
                        i < row.Count
                            ? row[i]
                            : string.Empty;

                    record[document.Columns[i]] =
                        value;
                }

                records.Add(record);
            }

            var options =
                new JsonSerializerOptions
                {
                    WriteIndented = true
                };

            string json =
                JsonSerializer.Serialize(
                    records,
                    options);

            File.WriteAllText(
                filePath,
                json);
        }
    }
}