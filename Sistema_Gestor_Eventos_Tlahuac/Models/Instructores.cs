using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestor_Eventos_Tlahuac.Models
{
    public class Instructores
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string? Especialidad { get; set; }

        public bool Activo { get; set; } = true;

        //Relacion con la tabla usuarios
        [Required]
        public string UsuarioId { get; set; }
        public ApplicationUser Usuario { get; set; }

        
    }
}
