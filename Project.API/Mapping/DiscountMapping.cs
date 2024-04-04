using AutoMapper;
using Project.DtoLayer.DiscountDto;
using Project.EntityLayer.Entities.Concretes;

namespace Project.API.Mapping
{
    public class DiscountMapping:Profile
    {
        public DiscountMapping()
        {
            CreateMap<Discount, GetDiscountDto>().ReverseMap();
            CreateMap<Discount, ResultDiscountDto>().ReverseMap();
            CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
            CreateMap<Discount, CreateDiscountDto>().ReverseMap();
        }
    }
}
