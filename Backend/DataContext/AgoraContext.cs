using Microsoft.EntityFrameworkCore;
using Service.Models;

namespace Backend.DataContext
{
    public class AgoraContext: DbContext
    {
        public DbSet<TipoInscripcion> TipoInscripciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public AgoraContext(){ }

        public AgoraContext(DbContextOptions<AgoraContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cargamos los datos iniciales de tipo de inscripciones(Público en general, Docentes, Estudiantes, Jubilados)
            modelBuilder.Entity<TipoInscripcion>().HasData(
                new TipoInscripcion { Id = 1, Nombre = "Público en general" },
                new TipoInscripcion { Id = 2, Nombre = "Docentes" },
                new TipoInscripcion { Id = 3, Nombre = "Estudiantes" },
                new TipoInscripcion { Id = 4, Nombre = "Jubilados" }
            );

            //cargamos los datos iniciales de usuarios
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Id = 1, Nombre = "Admin", Email = "admin@gmail.com", Password = "admin123", TipoUsuario = Service.Enums.TipoUsuarioEnum.Administrador },
                new Usuario { Id = 2, Nombre = "Juan Perez", Email = "perez@gmail.com", Password = "juan123", TipoUsuario = Service.Enums.TipoUsuarioEnum.Estudiante });




            // Configuramos las querys para que no devuelvan los elementos eliminados
            modelBuilder.Entity<TipoInscripcion>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Usuario>().HasQueryFilter(p => !p.IsDeleted);
        }
    }
}
