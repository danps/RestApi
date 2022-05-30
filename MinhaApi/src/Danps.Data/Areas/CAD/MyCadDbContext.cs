using Danps.Business.Areas.CAD.Models;
using Microsoft.EntityFrameworkCore;

namespace Danps.Data.Areas.CAD
{
    public class MyCadDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DanpsApiCore;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyCadDbContext).Assembly); 
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}