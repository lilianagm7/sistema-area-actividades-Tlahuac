using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestor_Eventos_Tlahuac.Models
{
    public class Participante
    {
        public int Id { get; set; }

        [Required]
        public int EventoId { get; set; }

        public Evento Evento { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public bool Asistio { get; set; } = false;


        //Relacion con la tabla usuarios
        [Required]
        public string UsuarioId { get; set; }
        public ApplicationUser Usuario { get; set; }

       
    }
}
