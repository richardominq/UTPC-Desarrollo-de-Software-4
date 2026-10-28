namespace CrudPersonasPostgreSQL.Models;

// Una instancia representa una fila de la tabla public.people.
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
}
