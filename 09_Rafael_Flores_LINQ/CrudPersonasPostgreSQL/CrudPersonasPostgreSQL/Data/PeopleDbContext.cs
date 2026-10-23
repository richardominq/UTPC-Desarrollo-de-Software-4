using System.Diagnostics;
using CrudPersonasPostgreSQL.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudPersonasPostgreSQL.Data;

public class PeopleDbContext : DbContext
{
    public DbSet<Person> People => Set<Person>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(DatabaseConfig.GetConnectionString());
#if DEBUG
        // Visible en Visual Studio: Ver > Salida > Depurar.
        optionsBuilder.LogTo(message => Debug.WriteLine(message),
            new[] { DbLoggerCategory.Database.Command.Name });
#endif
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var person = modelBuilder.Entity<Person>();
        person.ToTable("people", "public", table =>
        {
            table.HasCheckConstraint("ck_people_name", "length(btrim(name)) BETWEEN 1 AND 100");
            table.HasCheckConstraint("ck_people_age", "age BETWEEN 0 AND 120");
        });
        person.HasKey(p => p.Id);
        person.Property(p => p.Id).HasColumnName("id").UseIdentityAlwaysColumn();
        person.Property(p => p.Name).HasColumnName("name").HasMaxLength(100).IsRequired();
        person.Property(p => p.Age).HasColumnName("age").IsRequired();
    }
}
