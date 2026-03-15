using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestor_Eventos_Tlahuac.Models
{
    public class Asistencias
    {
        public int Id { get; set; }
        public bool Asistio { get; set; } = false;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        //Relaciones con otras tablas
        [Required]
        public int AlumnoId { get; set; }
        public Alumnos Alumno { get; set; }

        [Required]
        public int SesionId { get; set; }
        public Sesiones Sesion { get; set; }

        
    }
}
