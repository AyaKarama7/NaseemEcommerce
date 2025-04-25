using AutoMapper;
using NaseemEcommerce.DTOs;
using NaseemEcommerce.Models;

namespace NaseemEcommerce.Mappers
{
    public class ProductMapper:Profile
    {
        public ProductMapper()
        {
            CreateMap<Product, DisplayManyProductsDTO>().ReverseMap();
            CreateMap<Product, DisplayOneProductDTO>()
                .ForMember(dest => dest.Brand, opt => opt.MapFrom(src => src.Brand.Name))
                .ReverseMap();
        }
    }
}
