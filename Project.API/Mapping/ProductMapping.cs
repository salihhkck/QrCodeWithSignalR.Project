using AutoMapper;
using Project.DtoLayer.ProductDto;
using Project.EntityLayer.Entities.Concretes;

namespace Project.API.Mapping
{
    public class ProductMapping:Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductWithCategoryDto>().ReverseMap();

            CreateMap<Product, ResultProductWithCategoryDto>()

                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))

                .ReverseMap();
        }
    }
}
