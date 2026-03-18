using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestor_Eventos_Tlahuac.Models.Catalogos
{
    public class Espacio
    {

        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Nombre del espacio")]
        public string Nombre { get; set; }

        [Range(1, 1000, ErrorMessage = "La capacidad debe ser mayor a 0")]
        [Display(Name = "Capacidad máxima")]
        public int Capacidad { get; set; }


        //Relaciones 
        [Required]
        [Display(Name = "Lugar que corresponde")]
        public int LugarId { get; set; }
        public Lugar? Lugar { get; set; }
        public bool Activo { get; set; } = true;

        // Relacion: en un espacio pueden realizarse eventos y talleres
        //Relacion al navegar
        public ICollection<Evento> Eventos { get; set; } = new List<Evento>();

        public ICollection<Taller> Talleres { get; set; } = new List<Taller>();

    }
}
