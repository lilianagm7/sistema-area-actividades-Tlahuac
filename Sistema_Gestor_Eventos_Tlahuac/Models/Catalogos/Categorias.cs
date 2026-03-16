using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestor_Eventos_Tlahuac.Models
{
    public class Categorias
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(250)]
        public string? Descripcion { get; set; }

        public bool Activo { get; set; } = true;
    }
}