using AutoMapper;
using Project.DtoLayer.SocialMediaDto;
using Project.EntityLayer.Entities.Concretes;

namespace Project.API.Mapping
{
    public class SocialMediaMapping:Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
        }
    }
}
