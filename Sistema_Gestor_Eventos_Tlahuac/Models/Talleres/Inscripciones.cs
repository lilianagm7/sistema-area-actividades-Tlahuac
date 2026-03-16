using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestor_Eventos_Tlahuac.Models
{
    public class Inscripciones
    {
        public int Id { get; set; }

        public DateTime FechaInscripcion { get; set; } = DateTime.Now;
        public bool Activo { get; set; } = true;

        //Relaciones con tablas
        [Required]
        public int TallerId { get; set; }
        public Talleres Taller { get; set; }

        [Required]
        public int AlumnoId { get; set; }
        public Alumnos Alumno { get; set; }

        //Relacion para saber que usuario realizó la inscripción
        public string UsuarioRegistroId { get; set; }
        public ApplicationUser UsuarioRegistro { get; set; }

        
    }
}
