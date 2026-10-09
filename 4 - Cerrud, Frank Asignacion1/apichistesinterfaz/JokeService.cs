using System.Text.Json;

namespace apichistesinterfaz;

public class JokeService
{
    private readonly HttpClient _http = new();

    public JokeService()
    {
        var key = Environment.GetEnvironmentVariable("API_NINJAS_KEY")
                  ?? throw new InvalidOperationException("Falta la variable de entorno API_NINJAS_KEY");
        _http.DefaultRequestHeaders.Add("X-Api-Key", key.Trim());
    }

    public async Task<string> ObtenerChisteEnInglesAsync()
    {
        var resp = await _http.GetAsync("https://api.api-ninjas.com/v1/jokes");
        var json = await resp.Content.ReadAsStringAsync();
        if (!resp.IsSuccessStatusCode)
            throw new Exception($"API Ninjas respondió {(int)resp.StatusCode}: {json}");

        using var doc = JsonDocument.Parse(json);
        return doc.RootElement[0].GetProperty("joke").GetString() ?? "";
    }

    public async Task<string> TraducirAsync(string texto)
    {
        var url = "https://api.mymemory.translated.net/get?q="
                  + Uri.EscapeDataString(texto)
                  + "&langpair=" + Uri.EscapeDataString("en|es");

        var resp = await _http.GetAsync(url);
        var json = await resp.Content.ReadAsStringAsync();
        if (!resp.IsSuccessStatusCode)
            throw new Exception($"Traductor respondió {(int)resp.StatusCode}: {json}");

        using var doc = JsonDocument.Parse(json);
        return doc.RootElement.GetProperty("responseData")
                  .GetProperty("translatedText").GetString() ?? texto;
    }

    public async Task<string> ObtenerChisteEnEspanolAsync()
        => await TraducirAsync(await ObtenerChisteEnInglesAsync());
}