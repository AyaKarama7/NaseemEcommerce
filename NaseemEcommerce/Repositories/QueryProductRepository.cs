using Microsoft.EntityFrameworkCore;
using NaseemEcommerce.Data;
using NaseemEcommerce.Models;

namespace NaseemEcommerce.Repositories
{
    public class QueryProductRepository : IQueryProductRepository
    {
        private readonly AppDbContext context;
        public QueryProductRepository(AppDbContext context)
        {
            this.context = context;
        }
        public List<Product> GetAllProducts()
        {
            return context.Products.Include(p=>p.Brand).ToList();
        }

        public Product GetProductById(Guid id)
        {
            return context.Products.Include(p=>p.Brand).FirstOrDefault(p => p.Id == id);
        }
        public List<Product> GetProductsByBrand(string brand)
        {
            return context.Products.Include(p=>p.Brand).Where(p => p.Brand.Name == brand).ToList();
        }

        public List<Product> GetProductsByCategory(string category)
        {
            return context.Products.Where(p => p.Category == category).ToList();
        }

        public List<Product> GetProductsByPrice(decimal minPrice, decimal maxPrice)
        {
            return context.Products.Where(p => p.Price >= minPrice && p.Price<=maxPrice).ToList();
        }

    }
}
