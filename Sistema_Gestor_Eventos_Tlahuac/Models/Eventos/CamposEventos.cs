using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestor_Eventos_Tlahuac.Models
{
    public class CamposEventos
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string NombreCampo { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoCampo { get; set; }

        public bool Requerido { get; set; } = false;

        //Relacion con tabla evento
        [Required]
        public int EventoId { get; set; }
        public Eventos Evento { get; set; }
    }
}
