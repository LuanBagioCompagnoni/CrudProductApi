using CrudApi.Entity;
using Microsoft.EntityFrameworkCore;

namespace CotacaoMoeda.Context
{
    public class ApiContext : DbContext
    {

        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=CrudHub;User Id=postgres;Password=admin;");
        }

    }
}