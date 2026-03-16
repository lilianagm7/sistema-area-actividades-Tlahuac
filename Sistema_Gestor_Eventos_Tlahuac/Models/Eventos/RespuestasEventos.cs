using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestor_Eventos_Tlahuac.Models
{
    public class RespuestasEventos
    {
        public int Id { get; set; }
        //Relacion con las tablas Campos y Usuarios
        [Required]
        public int CampoEventoId { get; set; }
        public CamposEventos CampoEvento { get; set; }
        [Required]
        public string UsuarioId { get; set; }
        public ApplicationUser Usuario { get; set; }

        //Valor que se responde
        [Required]
        public string Valor { get; set; }

    }
}
