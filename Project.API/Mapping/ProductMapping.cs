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
        }
    }
}
