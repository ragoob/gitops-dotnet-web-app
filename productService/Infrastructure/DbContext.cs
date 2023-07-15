using Microsoft.EntityFrameworkCore;
using productService.Doamin.Entities;

namespace productService.Infrastructure {
    public class ProductContext : DbContext {

        public DbSet<Product> Products {get;set;}
        public ProductContext(DbContextOptions<ProductContext> opts): base(opts)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var product = modelBuilder.Entity<Product>();
            product.ToTable("product");
            product.HasKey(p=> p.Id);
        
        }
    }
}