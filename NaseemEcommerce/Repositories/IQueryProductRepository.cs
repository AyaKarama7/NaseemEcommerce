using NaseemEcommerce.Models;

namespace NaseemEcommerce.Repositories
{
    public interface IQueryProductRepository
    {
        List<Product> GetAllProducts();
        List<Product> GetProductsByCategory(string category);
        List<Product> GetProductsByPrice(decimal minPrice, decimal maxPrice);
        List<Product> GetProductsByBrand(string brand);
        Product GetProductById(Guid id);
    }
}
