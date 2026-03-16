using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestor_Eventos_Tlahuac.Models
{
    public class InstructorTaller
    {
        public int Id { get; set; }

        //Relaciones con las otras tablas
        [Required]
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        [Required]
        public int TallerId { get; set; }
        public Taller Taller { get; set; }
    }
}
