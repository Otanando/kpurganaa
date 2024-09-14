using Microsoft.EntityFrameworkCore;
using kpurganaa.Models; // Asegúrate de que este namespace sea correcto

namespace kpurganaa.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
    }
}
