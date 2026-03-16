using Sistema_Gestor_Eventos_Tlahuac.Models.Catalogos;
using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestor_Eventos_Tlahuac.Models
{
    public class Evento
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [StringLength(500)]
        public string? Descripcion { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }


        public int CapacidadMaxima { get; set; }

        public bool Activo { get; set; } = true;


        // Relaciones con las otras tablas
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public int? TipoActividadId { get; set; }
        public TipoActividad TipoActividad { get; set; }

<<<<<<< Updated upstream
        public int LugarId { get; set; }
        public Lugar Lugar { get; set; }
=======
>>>>>>> Stashed changes
        public ICollection<Inscripcion>? Inscripciones { get; set; }
    }
}
