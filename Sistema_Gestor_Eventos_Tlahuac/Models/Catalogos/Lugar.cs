using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestor_Eventos_Tlahuac.Models.Catalogos
{
    public class Lugar
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [StringLength(150)]
        public string Colonia { get; set; }

        [StringLength(100)]
        public string Seccion { get; set; }

        [StringLength(250)]
        public string Direccion { get; set; }

        public double? Latitud { get; set; }

        public double? Longitud { get; set; }

        public bool Activo { get; set; } = true;
    }
}
