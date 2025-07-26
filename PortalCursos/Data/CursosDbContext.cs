using Microsoft.EntityFrameworkCore;
using PortalCursos.Models;

namespace PortalCursos.Data
{
    public class CursosDbContext : DbContext
    {
        public CursosDbContext(DbContextOptions<CursosDbContext> options) : base(options) { }

        public DbSet<Curso> Cursos { get; set; }
    }
}
