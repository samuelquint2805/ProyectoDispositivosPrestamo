using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ProyectoDispositivosPrestamo.Models
{
    public class Device
    {
        [Key]
        public int IdDisp { get; set; }

        [NotNull]
        [Display(Name = "Tipo de dispositivo")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Tipo { get; set; }
        [NotNull]
        [Display(Name = "Procesador")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Procesador { get; set; }
        [NotNull]
        [Display(Name = "Almacenamiento")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int Almacenamiento { get; set; }
        [NotNull]
        [Display(Name = "Tarjeta gráfica")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string TarjetaGrafica { get; set; }

        [NotNull]
        [Display(Name = "Tipo de Préstamo")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string EstadoDisp { get; set; }

        // 🔗 Relación 1 a muchos con Prestamos
        public ICollection<Loan> Prestamos { get; set; }
    }
}
