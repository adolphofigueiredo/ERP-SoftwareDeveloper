using _20241024_GestioneMagazzino.Models.Dto;
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
        public IActionResult Post([FromBody] ProdottoDto prodottoDto)
        {
            if (prodottoDto == null)
            {
                return BadRequest("ProdottoDto cannot be null.");
            }

            var prodottoEntity = ProdottiMapper.Map(prodottoDto);
            _prodottoRepository.Post(prodottoEntity);

            return CreatedAtAction(nameof(GetById), new { id = prodottoEntity.Id }, prodottoDto);
        }

        [HttpGet]
        public IActionResult Get([FromQuery] ProdottoFilter filter)
        {
            var prodottoEntities = _prodottoRepository.Find(filter);
            var prodottoDtos = prodottoEntities.Select(ProdottiMapper.Map).ToList();
            return Ok(prodottoDtos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var prodottoEntity = _prodottoRepository.Get(id);
            if (prodottoEntity == null)
            {
                return NotFound($"Product with ID {id} cannot be found.");
            }
            var prodottoDto = ProdottiMapper.Map(prodottoEntity);
            return Ok(prodottoDto);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ProdottoDto prodottoDto)
        {
            if (prodottoDto == null)
            {
                return BadRequest("ProdottoDto cannot be null.");
            }

            var prodottoEntity = _prodottoRepository.Get(id);
            if (prodottoEntity == null)
            {
                return NotFound($"Product with ID {id} cannot be found.");
            }

            // Atualiza apenas os campos que foram passados no DTO
            if (!string.IsNullOrEmpty(prodottoDto.Descrizione))
            {
                prodottoEntity.Descrizione = prodottoDto.Descrizione;
            }

            // Atualiza o peso se for maior que 0
            if (prodottoDto.Peso > 0)
            {
                prodottoEntity.Peso = prodottoDto.Peso;
            }

            // Chamando o método Update
            _prodottoRepository.Update(prodottoEntity);

            return Ok(prodottoEntity);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var deletedProdotto = _prodottoRepository.Delete(id);
                return Ok(ProdottiMapper.Map(deletedProdotto));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
