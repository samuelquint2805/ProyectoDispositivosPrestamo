using System.ComponentModel.DataAnnotations;

namespace ProyectoDispositivosPrestamo.Models
{
    public class LoanEvent
    {
        [Key]
        public int IdEvento { get; set; }


        [StringLength(50)]
        [Display(Name = "Tipo de Préstamo")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string TipoPrestamos { get; set; }

        [StringLength(50)]
        [Display(Name = "Tipo de Evento")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string TipoEvento { get; set; }


        [Display(Name = "Fecha del Evento")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public DateTime FechaEvento { get; set; }



        //  Relación con Prestamos
        public ICollection<Loan> EventosPrestamos { get; set; }
    }
}
