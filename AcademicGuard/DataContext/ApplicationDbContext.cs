using Microsoft.EntityFrameworkCore;
using AcademicGuard.Models;

namespace AcademicGuard.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Models.Persona> Personas { get; set; }
        public DbSet<AcademicGuard.Models.DetallePersona> DetallePersona { get; set; } = default!;
        public DbSet<AcademicGuard.Models.Contacto> Contacto { get; set; } = default!;
        public DbSet<AcademicGuard.Models.Direccion> Direccion { get; set; } = default!;
        public DbSet<AcademicGuard.Models.Usuario> Usuario { get; set; } = default!;
        public DbSet<AcademicGuard.Models.Rol> Rol { get; set; } = default!;
        public DbSet<AcademicGuard.Models.Estudiante> Estudiante { get; set; } = default!;
        public DbSet<AcademicGuard.Models.Profesor> Profesor { get; set; } = default!;
        public DbSet<AcademicGuard.Models.Coordinador> Coordinador { get; set; } = default!;
        public DbSet<AcademicGuard.Models.Asistencia> Asistencia { get; set; } = default!;
        public DbSet<AcademicGuard.Models.Permiso> Permiso { get; set; } = default!;
        public DbSet<AcademicGuard.Models.Curso> Curso { get; set; } = default!;
        public DbSet<AcademicGuard.Models.Seccion> Seccion { get; set; } = default!;
        public DbSet<AcademicGuard.Models.Jornada> Jornada { get; set; } = default!;
        public DbSet<AcademicGuard.Models.Horario> Horario { get; set; } = default!;
        public DbSet<AcademicGuard.Models.Carrera> Carrera { get; set; } = default!;
    }
}
