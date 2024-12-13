using Microsoft.EntityFrameworkCore;
using AngularApp1.Server.Models;

namespace AngularApp1.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id = 1, Nombre = "Juan Perez", Telefono = "56912345678", Pais = "Chile" },
                new Cliente { Id = 2, Nombre = "Ana Lopez", Telefono = "56998765432", Pais = "Perú" },
                new Cliente { Id = 3, Nombre = "Carlos Gómez", Telefono = "56956789123", Pais = "Argentina" }
            );
        }
    }
}
