using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestor_Eventos_Tlahuac.Models
{
    public class Talleres
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }
        [StringLength(500)]
        public string? Descripcion { get; set; }
        [Required]
        public int CupoMaximo { get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }
        [Required]
        public DateTime FechaFin { get; set; }
        public bool Activo { get; set; } = true;


        // Relaciones con las otras tablas
        public int CategoriaId { get; set; }
        public Categorias Categoria { get; set; }
        public int TipoActividadId { get; set; }
        public TiposActividades TipoActividades { get; set; }
    }
}
