using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestor_Eventos_Tlahuac.Models
{
    public class Imagen
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Entidad { get; set; }
        [Required]
        public int EntidadId { get; set; }

        [Required]
        public string UrlImagen { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }
    }
}
