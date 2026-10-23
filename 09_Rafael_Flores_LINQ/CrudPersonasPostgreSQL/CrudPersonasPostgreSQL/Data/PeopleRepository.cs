using CrudPersonasPostgreSQL.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudPersonasPostgreSQL.Data;

// Cada operación usa su propio contexto y lo libera al terminar.
public class PeopleRepository
{
    public async Task<List<Person>> GetAsync(string search = "")
    {
        await using var db = new PeopleDbContext();
        IQueryable<Person> query = db.People.AsNoTracking();

        if (!string.IsNullOrWhiteSpace(search))
        {
            // Los signos % y _ escritos por el usuario se buscan como texto literal.
            string literal = search.Trim().Replace("!", "!!").Replace("%", "!%").Replace("_", "!_");
            string pattern = "%" + literal + "%";
            query = query.Where(p => EF.Functions.ILike(p.Name, pattern, "!"));
        }

        // El filtro y la ordenación se ejecutan en PostgreSQL antes de traer la lista.
        return await query.OrderBy(p => p.Id).ToListAsync();
    }

    public async Task<Person?> GetByIdAsync(int id)
    {
        await using var db = new PeopleDbContext();
        return await db.People.AsNoTracking().SingleOrDefaultAsync(p => p.Id == id);
    }

    public async Task<int> AddAsync(string name, int age)
    {
        Validate(name, age);
        await using var db = new PeopleDbContext();
        var person = new Person { Name = name.Trim(), Age = age };
        db.People.Add(person);
        await db.SaveChangesAsync();
        return person.Id; // PostgreSQL genera el identificador.
    }

    public async Task<bool> UpdateAsync(int id, string name, int age)
    {
        Validate(name, age);
        await using var db = new PeopleDbContext();
        Person? person = await db.People.SingleOrDefaultAsync(p => p.Id == id);
        if (person == null)
            return false;

        person.Name = name.Trim();
        person.Age = age;
        await db.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        await using var db = new PeopleDbContext();
        Person? person = await db.People.SingleOrDefaultAsync(p => p.Id == id);
        if (person == null)
            return false;

        db.People.Remove(person);
        await db.SaveChangesAsync();
        return true;
    }

    private static void Validate(string name, int age)
    {
        string? error = PersonRules.GetError(name, age);
        if (error != null)
            throw new ArgumentException(error);
    }
}
