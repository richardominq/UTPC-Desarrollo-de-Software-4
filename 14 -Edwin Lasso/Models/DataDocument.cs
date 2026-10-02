namespace CsvJsonManager.Models
{
    public class DataDocument
    {
        public string FilePath { get; set; } = string.Empty;

        public string FileName { get; set; } = string.Empty;

        public string FileType { get; set; } = string.Empty;

        public List<string> Columns { get; set; } = new();

        public List<List<string>> Rows { get; set; } = new();
    }
}