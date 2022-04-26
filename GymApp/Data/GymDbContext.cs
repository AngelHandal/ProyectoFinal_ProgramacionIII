using Microsoft.EntityFrameworkCore;

namespace GymApp.Data;
internal sealed class GymDbContext : DbContext
{

    public DbSet<Lista> clientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlite(connectionString: "Data Source=Gym.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Lista[] clientesToSeed = new Lista[6];

        for (int i = 1; i <= 6; i++)
        {
            clientesToSeed[i - 1] = new Lista
            {
                Id = i,
                Name = $"Cliente Nombre {i}",            
                LastName = $"Cliente Apellido {i}",

            };

        }// FIN FOR

        modelBuilder.Entity<Lista>().HasData(data: clientesToSeed);


    }


}

