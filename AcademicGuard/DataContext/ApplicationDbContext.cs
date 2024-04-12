using Microsoft.EntityFrameworkCore;

namespace AcademicGuard.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Models.Persona> Personas { get; set; }
    }
}
