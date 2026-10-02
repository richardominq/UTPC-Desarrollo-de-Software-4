using CsvHelper;
using CsvHelper.Configuration;
using CsvJsonManager.Models;
using System.Globalization;

namespace CsvJsonManager.Services
{
    public class CsvService
    {
        public DataDocument Load(string filePath)
        {
            var document = new DataDocument
            {
                FilePath = filePath,
                FileName = Path.GetFileName(filePath),
                FileType = "CSV"
            };

            string content = File.ReadAllText(filePath);

            LoadFromContent(content, document);

            return document;
        }

        // Cargar CSV desde Internet
        public async Task<DataDocument> LoadFromUrlAsync(string url)
        {
            using var client = new HttpClient();

            string content = await client.GetStringAsync(url);

            var uri = new Uri(url);

            string fileName = Path.GetFileName(uri.AbsolutePath);

            if (string.IsNullOrWhiteSpace(fileName))
                fileName = "datos.csv";

            var document = new DataDocument
            {
                // Vacío porque NO es una ruta local.
                // Esto hará que GuardarComo() se utilice.
                FilePath = "",
                FileName = fileName,
                FileType = "CSV"
            };

            LoadFromContent(content, document);

            return document;
        }

        // Procesar contenido CSV que ya tenemos en memoria
        public void LoadFromContent(
            string content,
            DataDocument document)
        {
            var config =
                new CsvConfiguration(
                    CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true,
                    MissingFieldFound = null,
                    BadDataFound = null
                };

            using var reader =
                new StringReader(content);

            using var csv =
                new CsvReader(reader, config);

            if (!csv.Read())
                return;

            csv.ReadHeader();

            var headers = csv.HeaderRecord;

            if (headers == null)
                return;

            document.Columns.AddRange(headers);

            while (csv.Read())
            {
                var row = new List<string>();

                for (int i = 0;
                     i < headers.Length;
                     i++)
                {
                    row.Add(
                        csv.GetField(i)
                        ?? string.Empty);
                }

                document.Rows.Add(row);
            }
        }

        public void Save(
            DataDocument document,
            string filePath)
        {
            var config =
                new CsvConfiguration(
                    CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true
                };

            using var writer =
                new StreamWriter(filePath);

            using var csv =
                new CsvWriter(writer, config);

            foreach (string column in document.Columns)
            {
                csv.WriteField(column);
            }

            csv.NextRecord();

            foreach (List<string> row in document.Rows)
            {
                foreach (string value in row)
                {
                    csv.WriteField(value);
                }

                csv.NextRecord();
            }
        }
    }
}
