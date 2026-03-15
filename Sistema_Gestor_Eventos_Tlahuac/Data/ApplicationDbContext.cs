using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sistema_Gestor_Eventos_Tlahuac.Models;

namespace Sistema_Gestor_Eventos_Tlahuac.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<TiposActividades> TiposActividades { get; set; }
        public DbSet<Talleres> Talleres { get; set; }
        public DbSet<Instructores> Instructores { get; set; }
        public DbSet<InstructoresTalleres> InstructoresTalleres { get; set; }
        public DbSet<Sesiones> Sesiones { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<Participantes> Participantes { get; set; }
        public DbSet<Alumnos> Alumnos { get; set; }
        public DbSet<Parentescos> Parentescos { get; set; }
        public DbSet<Inscripciones> Inscripciones { get; set; }
        public DbSet<Asistencias> Asistencias { get; set; }
        public DbSet<CamposEventos> CamposEventos { get; set; }
        public DbSet<RespuestasEventos> RespuestasEventos { get; set; }
        public DbSet<Imagenes> Imagenes { get; set; }



        //No permite que se eliminen valores cascada, por parte de inscripciones.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Inscripciones>()
                .HasOne(i => i.UsuarioRegistro)
                .WithMany()
                .HasForeignKey(i => i.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict); //Restringe borrar registros
        }
        /*
         ***CREACION DE UN INDICE PARA BUSQUEDA DE IMAGENES
         protected override void OnModelCreating(ModelBuilder modelBuilder){
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Imagenes>()
                    .HasIndex(i => new { i.Entidad, i.EntidadId });
          }
        **MIGRACION 
            Add-Migration AddIndexImagenes
            Update-Database
         */
    }
}
