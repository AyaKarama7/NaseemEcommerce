using NaseemEcommerce.DTOs;
using NaseemEcommerce.Models;
using NaseemEcommerce.Repositories;

namespace NaseemEcommerce.Services
{
    public interface IProductServices
    {
        List<DisplayManyProductsDTO> GetAllProducts();
        List<DisplayManyProductsDTO> GetProductsByCategory(string category);
        List<DisplayManyProductsDTO> GetProductsByPrice(decimal minPrice, decimal maxPrice);
        List<DisplayManyProductsDTO> GetProductsByBrand(string brand);
        DisplayOneProductDTO GetProductById(Guid id);
    }
}
