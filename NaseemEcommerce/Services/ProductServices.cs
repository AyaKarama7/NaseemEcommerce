using AutoMapper;
using NaseemEcommerce.DTOs;
using NaseemEcommerce.Models;
using NaseemEcommerce.Repositories;

namespace NaseemEcommerce.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IQueryProductRepository queryProduct;
        private readonly IMapper mapper;
        public ProductServices(IQueryProductRepository queryProduct, IMapper mapper)
        {
            this.queryProduct = queryProduct;
            this.mapper = mapper;
        }

        public List<DisplayManyProductsDTO> GetAllProducts()
        {
            var products = queryProduct.GetAllProducts();
            var prodctsDTO = mapper.Map<List<DisplayManyProductsDTO>>(products);
            return prodctsDTO;
        }

        public DisplayOneProductDTO GetProductById(Guid id)
        {
            var product = queryProduct.GetProductById(id);
            var productDTO = mapper.Map<DisplayOneProductDTO>(product);
            return productDTO;
        }

        public List<DisplayManyProductsDTO> GetProductsByBrand(string brand)
        {
            var products = queryProduct.GetProductsByBrand(brand);
            var prodctsDTO = mapper.Map<List<DisplayManyProductsDTO>>(products);
            return prodctsDTO;
        }

        public List<DisplayManyProductsDTO> GetProductsByCategory(string category)
        {
            var products = queryProduct.GetProductsByCategory(category);
            var prodctsDTO = mapper.Map<List<DisplayManyProductsDTO>>(products);
            return prodctsDTO;
        }

        public List<DisplayManyProductsDTO> GetProductsByPrice(decimal minPrice, decimal maxPrice)
        {
            var products = queryProduct.GetProductsByPrice(minPrice,maxPrice);
            var prodctsDTO = mapper.Map<List<DisplayManyProductsDTO>>(products);
            return prodctsDTO;
        }
    }
}
