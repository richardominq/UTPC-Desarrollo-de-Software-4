namespace CrudPersonasPostgreSQL.Models;

public static class PersonRules
{
    public static string? GetError(string name, int age)
    {
        if (string.IsNullOrWhiteSpace(name) || name.Trim().Length > 100)
            return "Escriba un nombre de 1 a 100 caracteres.";
        if (age < 0 || age > 120)
            return "Escriba una edad entera entre 0 y 120.";
        return null;
    }
}
