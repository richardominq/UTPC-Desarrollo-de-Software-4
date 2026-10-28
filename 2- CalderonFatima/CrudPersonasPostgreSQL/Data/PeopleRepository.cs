using System.Linq;
using CrudPersonasPostgreSQL.Models; // Clase Person y reglas de validación.
using Microsoft.EntityFrameworkCore; 

namespace CrudPersonasPostgreSQL.Data;

// Contiene las operaciones para consultar, agregar, editar y eliminar personas.
public class PeopleRepository
{
    // Obtiene las personas. 
    public async Task<List<Person>> GetAsync(string search = "")
    {
        // El contexto permite trabajar con la base y se libera al terminar.
        await using var db = new PeopleDbContext();

        // Prepara una consulta de lectura, sin seguimiento de cambios.
        IQueryable<Person> query = db.People.AsNoTracking();

        if (!string.IsNullOrWhiteSpace(search))
        {
            string literal = search.Trim()
                .Replace("!", "!!")
                .Replace("%", "!%")
                .Replace("_", "!_");

            // Permite encontrar el texto en cualquier parte del nombre.
            string pattern = "%" + literal + "%";

            // Filtra por nombre sin distinguir mayúsculas y minúsculas.
            query = query.Where(p => EF.Functions.ILike(p.Name, pattern, "!"));
        }

        // Ordena por ID, ejecuta la consulta y devuelve la lista.
        return await query.OrderBy(p => p.Id).ToListAsync();
    }

    // Busca una persona por su ID. Si no existe, devuelve null.
    public async Task<Person?> GetByIdAsync(int id)
    {
        await using var db = new PeopleDbContext();

        return await db.People.AsNoTracking()
            .SingleOrDefaultAsync(p => p.Id == id);
    }

    // Agrega una persona y devuelve su ID.
    public async Task<int> AddAsync(string name, int age)
    {
        Validate(name, age);

        await using var db = new PeopleDbContext();

        // Crea la persona y elimina los espacios de los extremos del nombre.
        var person = new Person { Name = name.Trim(), Age = age };

        // Prepara el nuevo registro.
        db.People.Add(person);

        // Guarda el registro en PostgreSQL.
        await db.SaveChangesAsync();

        return person.Id; // Devuelve el ID que generó PostgreSQL.
    }

    // Cambia el nombre y la edad de la persona indicada.
    public async Task<bool> UpdateAsync(int id, string name, int age)
    {
        Validate(name, age);

        await using var db = new PeopleDbContext();

        // Busca el registro antes de modificarlo.
        Person? person = await db.People.SingleOrDefaultAsync(p => p.Id == id);

        if (person == null)
            return false; // El registro no existe.

        // Asigna los nuevos datos.
        person.Name = name.Trim();
        person.Age = age;

        // Guarda los cambios realizados en el objeto.
        await db.SaveChangesAsync();

        return true;
    }

    // Elimina la persona que corresponde al ID recibido.
    public async Task<bool> DeleteAsync(int id)
    {
        await using var db = new PeopleDbContext();

        Person? person = await db.People.SingleOrDefaultAsync(p => p.Id == id);

        if (person == null)
            return false;

        // Marca el registro para eliminarlo.
        db.People.Remove(person);

        // Confirma la eliminación en la base de datos.
        await db.SaveChangesAsync();

        return true;
    }

    // Revisa que el nombre y la edad cumplan las reglas del programa.
    private static void Validate(string name, int age)
    {
        string? error = PersonRules.GetError(name, age);

        // Si hay un dato incorrecto, detiene la operación con el mensaje correspondiente.
        if (error != null)
            throw new ArgumentException(error);
    }
}
