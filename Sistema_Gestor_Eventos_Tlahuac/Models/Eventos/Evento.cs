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
        public DateTime Fecha { get; set; }

        [StringLength(200)]
        public string? Lugar { get; set; }

        public int CapacidadMaxima { get; set; }

        public bool Activo { get; set; } = true;


        // Relaciones con las otras tablas
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public int TipoActividadId { get; set; }
        public TipoActividad TipoActividades { get; set; }
    }
}
