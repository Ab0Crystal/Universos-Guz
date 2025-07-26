
using Microsoft.EntityFrameworkCore;
using ReservasEventos.Models;

namespace ReservasEventos.Data
{
    public class ReservasDbContext : DbContext
    {
        public ReservasDbContext(DbContextOptions<ReservasDbContext> options) : base(options) { }

        public DbSet<Asiento> Asientos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
    }
}