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
        public IActionResult Post([FromBody] FornitoreDto fornitoreDto)
        {
            if (fornitoreDto == null)
            {
                return BadRequest("FornitoreDto cannot be null.");
            }

            var fornitoreEntity = FornitoriMapper.Map(fornitoreDto);
            _fornitoreRepository.Post(fornitoreEntity);

            return CreatedAtAction(nameof(GetById), new { id = fornitoreEntity.Id }, fornitoreDto);
        }

        [HttpGet]
        public IActionResult Get([FromQuery] FornitoreFilter filter)
        {
            var fornitoreEntities = _fornitoreRepository.Find(filter);
            var fornitoreDtos = fornitoreEntities.Select(FornitoriMapper.Map).ToList();
            return Ok(fornitoreDtos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)  // Certifique-se de que este método está presente
        {
            var fornitoreEntity = _fornitoreRepository.Get(id);
            if (fornitoreEntity == null)
            {
                return NotFound($"Client with ID {id} not found.");
            }
            var fornitoreDto = FornitoriMapper.Map(fornitoreEntity);
            return Ok(fornitoreDto);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] FornitoreDto fornitoreDto)
        {
            if (fornitoreDto == null)
            {
                return BadRequest("ClienteDto cannot be null.");
            }

            var fornitoreEntity = FornitoriMapper.Map(fornitoreDto);

            try
            {
                var updatedFornitore = _fornitoreRepository.Put(id, fornitoreEntity);
                return Ok(FornitoriMapper.Map(updatedFornitore));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var deletedFornitore = _fornitoreRepository.Delete(id);
                return Ok(FornitoriMapper.Map(deletedFornitore));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}