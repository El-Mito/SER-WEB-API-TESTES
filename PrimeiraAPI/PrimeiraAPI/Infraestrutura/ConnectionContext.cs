using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PrimeiraAPI.Model;

namespace PrimeiraAPI.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Produtos> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        =>optionsBuilder.UseSqlServer("Server=localhost;Database=Produtos;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true;");
    }

}
