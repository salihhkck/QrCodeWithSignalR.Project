using AutoMapper;
using Project.DtoLayer.ContactDto;
using Project.EntityLayer.Entities.Concretes;

namespace Project.API.Mapping
{
    public class ContactMapping:Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact, ResultContactDto>().ReverseMap();
            CreateMap<Contact, GetContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
            CreateMap<Contact, CreateContactDto>().ReverseMap();
        }
    }
}
