using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sistema_Gestor_Eventos_Tlahuac.Models;
using Sistema_Gestor_Eventos_Tlahuac.Models.Catalogos;

namespace Sistema_Gestor_Eventos_Tlahuac.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<TipoActividad> TiposActividades { get; set; }
        public DbSet<Espacio>Espacios { get; set; }
        public DbSet<Lugar> Lugares { get; set; }
        public DbSet<Taller> Talleres { get; set; }
        public DbSet<Instructor> Instructores { get; set; }
        public DbSet<InstructorTaller> InstructoresTalleres { get; set; }
        public DbSet<Sesion> Sesiones { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Participante> Participantes { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Parentesco> Parentescos { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<CampoEvento> CamposEventos { get; set; }
        public DbSet<RespuestaEvento> RespuestasEventos { get; set; }
        public DbSet<Imagen> Imagenes { get; set; }



        //No permite que se eliminen valores cascada, por parte de inscripciones.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Inscripcion>()
                .HasOne(i => i.UsuarioRegistro)
                .WithMany()
                .HasForeignKey(i => i.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict); //Restringe borrar registros
        }
        public DbSet<Sistema_Gestor_Eventos_Tlahuac.Models.Catalogos.Espacio> Espacio { get; set; } = default!;
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
