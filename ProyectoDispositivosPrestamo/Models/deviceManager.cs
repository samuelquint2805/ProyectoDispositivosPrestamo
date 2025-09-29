using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ProyectoDispositivosPrestamo.Models
{
    public class deviceManager
    {
        [Key]
        public int IdAdmin { get; set; }
        [NotNull]
        [Display(Name = "Tarjeta gráfica")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Nombre { get; set; }
        [NotNull]
        [Display(Name = "Tarjeta gráfica")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Usuario { get; set; }
        [NotNull]
        [Display(Name = "Tarjeta gráfica")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Contraseña { get; set; }

        // Relación 1 a muchos con Prestamos
        public ICollection<Loan> Prestamos { get; set; }
    }
}
