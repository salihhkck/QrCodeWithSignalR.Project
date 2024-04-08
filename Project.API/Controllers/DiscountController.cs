using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BusinessLayer.Abstracts;
using Project.DtoLayer.ContactDto;
using Project.DtoLayer.DiscountDto;
using Project.EntityLayer.Entities.Concretes;

namespace Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult DiscountList()
        {
            var value = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            _discountService.TAdd(new Discount()
            {
                 Amount = createDiscountDto.Amount,
                  Description = createDiscountDto.Description, 
                   ImageUrl = createDiscountDto.ImageUrl,
                     Title  = createDiscountDto.Title
            });

            return Ok("İndirimler Başarılı Şekilde Eklendi!");
        }

        [HttpDelete]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            _discountService.TDelete(value);
            return Ok("İndirimler Başarılı Şekilde Silindi!");
        }

        [HttpGet("GetDiscount")]
        public IActionResult GetDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            _discountService.TUpdate(new Discount()
            {
                 DiscountID = updateDiscountDto.DiscountID,
                 Title = updateDiscountDto.Title,
                  Amount = updateDiscountDto.Amount,
                    Description = updateDiscountDto.Description,
                    ImageUrl = updateDiscountDto.ImageUrl,
                     
            });

            return Ok("İndirim Bilgisi Başarılı Şekilde Güncellendi!");
        }
    }
}

