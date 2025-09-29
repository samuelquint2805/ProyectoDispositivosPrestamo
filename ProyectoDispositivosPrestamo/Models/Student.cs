using System.ComponentModel.DataAnnotations;

namespace ProyectoDispositivosPrestamo.Models
{
    public class Student
    {
        [Key]
        public int IdEst { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Nombre { get; set; }

        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Usuario { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Contraseña { get; set; }

        [Display(Name = "Correo institucional")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string CorreoIns { get; set; }

        [Display(Name = "Carnet")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int Carnet { get; set; }

        [Display(Name = "Estado Cuenta")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string EstadoCuenta { get; set; }

        // Relación 1 a muchos con Prestamos
        public ICollection<Loan> Prestamos { get; set; }
    }
}
