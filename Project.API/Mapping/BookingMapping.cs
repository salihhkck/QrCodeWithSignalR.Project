using AutoMapper;
using Project.DtoLayer.BookingDto;
using Project.EntityLayer.Entities.Concretes;

namespace Project.API.Mapping
{
    public class BookingMapping:Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking, GetBookingDto>().ReverseMap();
            CreateMap<Booking, CreateBookinDto>().ReverseMap();
            CreateMap<Booking, UpdateBookingDto>().ReverseMap();
            CreateMap<Booking, ResultBookingDto>().ReverseMap();
        }
    }
}
