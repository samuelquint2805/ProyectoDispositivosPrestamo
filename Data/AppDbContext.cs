using Microsoft.EntityFrameworkCore;
using ProyectoDispositivosPrestamo.Models;

namespace ProyectoDispositivosPrestamo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}