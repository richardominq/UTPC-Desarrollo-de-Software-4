using System.Text.Json;
using Npgsql;

namespace CrudPersonasPostgreSQL.Data;

public static class DatabaseConfig
{
    public static string GetConnectionString()
    {
        // La variable es opcional y tiene prioridad sobre el archivo JSON.
        string? fromEnvironment = Environment.GetEnvironmentVariable("CRUD_PERSONAS_CONNECTION");
        if (!string.IsNullOrWhiteSpace(fromEnvironment))
            return fromEnvironment;

        string path = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
        if (!File.Exists(path))
            throw new InvalidOperationException("No se encontró appsettings.json junto al programa.");

        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var settings = JsonSerializer.Deserialize<AppSettings>(File.ReadAllText(path), options);
        DatabaseSettings db = settings?.Database
            ?? throw new InvalidOperationException("Falta la sección Database en appsettings.json.");

        if (string.IsNullOrWhiteSpace(db.Host) || string.IsNullOrWhiteSpace(db.Name)
            || string.IsNullOrWhiteSpace(db.Username) || db.Port < 1 || db.Port > 65535)
            throw new InvalidOperationException("Revise Host, Port, Name y Username en appsettings.json.");
        if (db.Password == "TU_CONTRASEÑA")
            throw new InvalidOperationException("Abra appsettings.json y escriba la contraseña de su usuario de PostgreSQL.");

        // El constructor maneja caracteres como ; o comillas dentro de la contraseña.
        return new NpgsqlConnectionStringBuilder
        {
            Host = db.Host,
            Port = db.Port,
            Database = db.Name,
            Username = db.Username,
            Password = db.Password,
            Timeout = 5,
            CommandTimeout = 15
        }.ConnectionString;
    }
}

public sealed class AppSettings
{
    public DatabaseSettings? Database { get; set; }
}

public sealed class DatabaseSettings
{
    public string Host { get; set; } = "localhost";
    public int Port { get; set; } = 5432;
    public string Name { get; set; } = "crud_personas";
    public string Username { get; set; } = "postgres";
    public string Password { get; set; } = "";
}
