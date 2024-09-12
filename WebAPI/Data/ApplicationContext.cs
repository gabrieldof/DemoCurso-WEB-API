using Microsoft.EntityFrameworkCore;
using WebAPI.Entities;

namespace WebAPI.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions <ApplicationContext> options) : base(options) { }

        public DbSet<Musico> Musicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // DataSeed: Agregar algunos datos iniciales
            modelBuilder.Entity<Musico>().HasData(
                             new Musico { Id = 1, Nombre = "Gustavo Cerati" },
                             new Musico { Id = 2, Nombre = "Indio Solari" },
                             new Musico { Id = 3, Nombre = "Miranda" },
                             new Musico { Id = 4, Nombre = "Charly García" },
                             new Musico { Id = 5, Nombre = "Divididos" },
                             new Musico { Id = 6, Nombre = "Mercedes Sosa" }
            );

        }
    }
}
