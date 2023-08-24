using PsychicPets.Pets;
using Microsoft.EntityFrameworkCore;

namespace PsychicPets.EntityFramework;
public class PetsContext : DbContext
{
    public DbSet<Pet> Pets { get; set; }

    public PetsContext(DbContextOptions options) : base(options)
    {

    }
}