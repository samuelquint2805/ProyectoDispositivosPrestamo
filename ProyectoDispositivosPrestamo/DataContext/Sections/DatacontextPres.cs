using Microsoft.EntityFrameworkCore;
using ProyectoDispositivosPrestamo.Models;

namespace ProyectoDispositivosPrestamo.DataContext.Sections
{
    public class DatacontextPres : DbContext
    {
        public DatacontextPres(DbContextOptions<DatacontextPres> options)
           : base(options) { }

        public DbSet<Student> Estudiante { get; set; }
        public DbSet<deviceManager> AdminDisp { get; set; }
        public DbSet<Device> Dispositivos { get; set; }
        public DbSet<Loan> Prestamos { get; set; }
        public DbSet<LoanEvent> EventoPrestamos { get; set; }
    }
}
