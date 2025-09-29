using System.ComponentModel.DataAnnotations;

namespace ProyectoDispositivosPrestamo.Models
{
    public class Loan
    {
        [Key]
        public int IdPrestamos { get; set; }



        // Llaves foráneas

        public int IdEst { get; set; }
        public Student Estudiante { get; set; }

        public int IdDispositivo { get; set; }
        public Device Dispositivo { get; set; }

        public int IdAdminDis { get; set; }
        public deviceManager AdminDisp { get; set; }

        public int EstadoPrestamos { get; set; }
        public LoanEvent EventoDisp { get; set; }
    }
}
