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
    public class ProdottoController : ControllerBase
    {
        private readonly ProdottoRepository _prodottoRepository;

        public ProdottoController(ProdottoRepository prodottoRepository)
        {
            _prodottoRepository = prodottoRepository;
        }

        [HttpPost]
        public IActionResult Post(ProdottoDto prodottoDto)
        {
            var prodottoEntity = ProdottiMapper.From(prodottoDto);
            _prodottoRepository.Post(prodottoEntity);
            return Ok();
        }

    }
}