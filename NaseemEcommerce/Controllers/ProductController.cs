using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NaseemEcommerce.Services;

namespace NaseemEcommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductServices productServices;
        public ProductController(IProductServices productServices)
        {
            this.productServices = productServices;
        }
        [HttpGet("products-all")]
        public IActionResult GetAllProducts()
        {
            return Ok(productServices.GetAllProducts());
        }
        [HttpGet("products-category")]
        public IActionResult GetProductsByCategory(string category)
        {
            return Ok(productServices.GetProductsByCategory(category));
        }
        [HttpGet("products-price")]
        public IActionResult GetProductsByPrice(decimal minPrice,decimal maxPrice)
        {
            return Ok(productServices.GetProductsByPrice(minPrice, maxPrice));
        }
        [HttpGet("products-brand")]
        public IActionResult GetProductsByBrand(string brand)
        {
            return Ok(productServices.GetProductsByBrand(brand));
        }
        [HttpGet("products-id")]
        public IActionResult GetProductById(Guid id)
        {
            return Ok(productServices.GetProductById(id));
        }
    }
}
