using System.ComponentModel.DataAnnotations;

namespace ProyectoDispositivosPrestamo.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Matricula { get; set; }
        public string Carrera { get; set; }
        public string Correo { get; set; }
    }
}