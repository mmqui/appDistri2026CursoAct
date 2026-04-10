using app.clientesChGio.entities.models;
using Microsoft.EntityFrameworkCore;

namespace app.clientesChGio.dataAccess.context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DireccionCliente> DireccionClientes { get; set; }

    }
}
