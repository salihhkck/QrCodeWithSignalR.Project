using AutoMapper;
using Project.DtoLayer.CategoryDto;
using Project.EntityLayer.Entities.Concretes;

namespace Project.API.Mapping
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, GetCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
        }
    }
}
