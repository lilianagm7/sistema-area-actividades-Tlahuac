using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestor_Eventos_Tlahuac.Models.Catalogos
{
    public class Espacio
    {

        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Display(Name = "Capacidad máxima")]
        public int Capacidad { get; set; }
       

        //Relaciones 
        [Display(Name = "Lugar que corresponde")]
        public int LugarId { get; set; }
        public Lugar Lugar { get; set; }
        public bool Activo { get; set; } = true;
        //Relacion de muchos 
        public ICollection<Evento> Eventos { get; set; } = new List<Evento>();

        public ICollection<Taller> Talleres { get; set; } = new List<Taller>();

    }
}
