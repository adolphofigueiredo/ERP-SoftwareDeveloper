using _20241024_GestioneMagazzino.Models;
using _20241024_GestioneMagazzino.Models.Dto;
using _20241024_GestioneMagazzino.Models.Entities;
using _20241024_GestioneMagazzino.Models.Filters;
using _20241024_GestioneMagazzino.Models.Mappers;
using _20241024_GestioneMagazzino.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _20241024_GestioneMagazzino.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FornitoreController : ControllerBase
    {
        private readonly FornitoreRepository _fornitoreRepository;

        public FornitoreController(FornitoreRepository fornitoreRepository)
        {
            _fornitoreRepository = fornitoreRepository;
        }

        [HttpPost]
        public IActionResult Post(FornitoreDto fornitoreDto)
        {
            var fornitoreEntity = FornitoriMapper.From(fornitoreDto);
            _fornitoreRepository.Post(fornitoreEntity);
            return Ok();
        }

    }
}
