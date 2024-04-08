using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BusinessLayer.Abstracts;
using Project.DtoLayer.CategoryDto;
using Project.DtoLayer.ContactDto;
using Project.EntityLayer.Entities.Concretes;

namespace Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var value = _mapper.Map<List<ResultContactDto>>(_contactService.TGetAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _contactService.TAdd(new Contact()
            {
                Phone = createContactDto.Phone,
                FooterDescription = createContactDto.FooterDescription,
                Location = createContactDto.Location,
                Mail = createContactDto.Mail
            });

            return Ok("İletişim Bilgisi Başarılı Şekilde Eklendi!");
        }

        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetById(id);
            _contactService.TDelete(value);
            return Ok("Kategori Başarılı Şekilde Silindi!");
        }

        [HttpGet("GetContact")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            _contactService.TUpdate(new Contact()
            {
                 ContactID = updateContactDto.ContactID,
                 Mail = updateContactDto.Mail,
                  Location = updateContactDto.Location,
                    FooterDescription   = updateContactDto.FooterDescription,
                     Phone = updateContactDto.Phone,
            });

            return Ok("İletişim Bilgisi Başarılı Şekilde Güncellendi!");
        }
    }
}
