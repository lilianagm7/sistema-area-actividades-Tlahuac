using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestor_Eventos_Tlahuac.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la categoría es obligatorio")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(250)]
        [Display(Name = "Descripción")]
        public string? Descripcion { get; set; }

        public bool Activo { get; set; } = true;
        // Relación donde categoria puede tener muchos eventos
        public ICollection<Evento>? Eventos { get; set; }
    }
}