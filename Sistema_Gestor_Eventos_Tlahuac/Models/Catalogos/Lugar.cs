using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestor_Eventos_Tlahuac.Models.Catalogos
{
    public class Lugar
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
<<<<<<< Updated upstream
=======
        [Display(Name = "Nombre del lugar")]
>>>>>>> Stashed changes
        public string Nombre { get; set; }
        [StringLength(150)]
        public string Colonia { get; set; }
        [StringLength(100)]
        [Display(Name = "Sección")]
        public string Seccion { get; set; }
        [StringLength(250)]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        public double? Latitud { get; set; }
        public double? Longitud { get; set; }
        public bool Activo { get; set; } = true;

<<<<<<< Updated upstream
        // Relación donde categoria puede tener muchos eventos
        public ICollection<Evento>? Eventos { get; set; }
        // Relación donde categoria puede tener muchos talleres
        public ICollection<Taller> Talleres { get; set; } = new List<Taller>();
=======
        // Relación: un lugar puede tener varios espacios
        public ICollection<Espacio> Espacios { get; set; } = new List<Espacio>();
>>>>>>> Stashed changes
    }
}
