using Microsoft.EntityFrameworkCore;
using Modelo;
using Modelo.Repositorios;

namespace ComponenteNegocio.Data
{
    public class BancoContext : DbContext, IBancoContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        // ? (diz ao c# que o tipo pode ser nulo)
        public DbSet<Usuario>? Usuario { get; set; }
    }
}
