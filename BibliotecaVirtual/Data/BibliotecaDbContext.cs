using Microsoft.EntityFrameworkCore;
using BibliotecaVirtual.Models;

namespace BibliotecaVirtual.Data
{
    public class BibliotecaDbContext : DbContext
    {
        public BibliotecaDbContext(DbContextOptions<BibliotecaDbContext> options) : base(options) { }

        public DbSet<Libro> Libros { get; set; }
    }
}
