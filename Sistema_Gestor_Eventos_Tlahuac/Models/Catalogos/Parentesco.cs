using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestor_Eventos_Tlahuac.Models
{
    public class Parentesco
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="¿Qué es del alumno?")]
        public string Nombre { get; set; }

        public bool Activo { get; set; } = true;

        // Relación donde parentesco puede tener muchos alumnos
        public ICollection<Alumno> Alumnos { get; set; } = new List<Alumno>();
    }
}
