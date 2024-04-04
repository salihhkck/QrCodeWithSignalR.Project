using AutoMapper;
using Project.DtoLayer.FeatureDto;
using Project.EntityLayer.Entities.Concretes;

namespace Project.API.Mapping
{
    public class FeatureMapping:Profile
    {
        public FeatureMapping()
        {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, GetFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
        }
    }
}
