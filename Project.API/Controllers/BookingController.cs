using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BusinessLayer.Abstracts;
using Project.DataAccessLayer.Abstracts;
using Project.DtoLayer.BookingDto;
using Project.EntityLayer.Entities.Concretes;

namespace Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBooking(CreateBookinDto createBookinDto)
        {
            Booking booking = new Booking()
            {
                Mail = createBookinDto.Mail,
                Date = createBookinDto.Date,
                PersonCount = createBookinDto.PersonCount,
                Phone = createBookinDto.Phone,
                Name = createBookinDto.Name
            };

            _bookingService.TAdd(booking);
            return Ok("Rezervasyon başarılı şekilde yapıldı!");
        }

        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            _bookingService.TDelete(value);
            return Ok("Rezervasyon silme işlemi başarılı!");
        }

        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking()
            {
                BookingID = updateBookingDto.BookingID,
                Mail = updateBookingDto.Mail,
                Date = updateBookingDto.Date,
                PersonCount = updateBookingDto.PersonCount,
                Phone = updateBookingDto.Phone,
                Name = updateBookingDto.Name
            };
            _bookingService.TUpdate(booking);
            return Ok("Rezervasyon başarılı bir şekilde güncellendi!");
        }

        [HttpGet("GetBooking")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            return Ok(value);
        }
    }
}
