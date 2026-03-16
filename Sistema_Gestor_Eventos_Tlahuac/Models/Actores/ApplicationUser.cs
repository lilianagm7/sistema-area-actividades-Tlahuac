using Microsoft.AspNetCore.Identity;
namespace Sistema_Gestor_Eventos_Tlahuac.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Nombre { get; set; }

        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
