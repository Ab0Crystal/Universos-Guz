using Microsoft.EntityFrameworkCore;
using TiendaOnlineGadgets.Models;

namespace TiendaOnlineGadgets.Data
{
    public class TiendaDbContext : DbContext
    {
        public TiendaDbContext(DbContextOptions<TiendaDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
