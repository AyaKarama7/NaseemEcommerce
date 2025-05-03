using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NaseemEcommerce.Models;

namespace NaseemEcommerce.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItems> CartItems { get; set; }
        public DbSet<Review> Reviews { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasMany(p => p.Reviews)
                .WithOne(r=>r.Product)
                .HasForeignKey(r=>r.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Product>().HasOne(p => p.Brand)
                .WithMany(b => b.Products)
                .HasForeignKey(p => p.BrandId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<CartItems>().HasKey(ci => new { ci.CartId, ci.ProductId });
            modelBuilder.Entity<CartItems>().HasOne(ci => ci.Product)
                .WithMany(p => p.CartItems)
                .HasForeignKey(p=>p.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<CartItems>().HasOne(ci => ci.Cart)
                .WithMany(c => c.CartItems)
                .HasForeignKey(c=>c.CartId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);

        }
    }
}
