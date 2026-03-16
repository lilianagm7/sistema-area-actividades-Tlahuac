using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestor_Eventos_Tlahuac.Models
{
    public class Alumno
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        public string ApellidoPaterno { get; set; }
        [Required]
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Alergias { get; set; }
        public bool Activo { get; set; } = true;

        // Relacion con tabla usuarios --> Responsable del alumno
        [Required]
        public string UsuarioId { get; set; }
        public ApplicationUser Usuario { get; set; }

        // Relacion para definir parentesco del responsable
        public int ParentescoId { get; set; }
        public Parentesco Parentesco { get; set; }
    }
}
