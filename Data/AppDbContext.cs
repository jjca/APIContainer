using Microsoft.EntityFrameworkCore;
using APIContainers.Models;

namespace APIContainers.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Contenedor> Contenedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var contenedores = new List<Contenedor>();
            var navieras = new[] { "Maersk", "MSC", "CMA CGM", "Hapag-Lloyd", "Evergreen" };
            var estatuses = new[] { "Activo", "Inactivo", "Pendiente", "En tránsito", "Entregado" };
            var letras = new[] { "ABC", "DEF", "GHI", "JKL", "MNO" };
            for (int i = 1; i <= 2000; i++)
            {
                contenedores.Add(new Contenedor
                {
                    Id = i,
                    Estatus = estatuses[i % estatuses.Length],
                    Naviera = navieras[i % navieras.Length],
                    Codigo = $"{letras[i % letras.Length]}-{i}"
                });
            }
            modelBuilder.Entity<Contenedor>().HasData(contenedores);
        }
    }
}
