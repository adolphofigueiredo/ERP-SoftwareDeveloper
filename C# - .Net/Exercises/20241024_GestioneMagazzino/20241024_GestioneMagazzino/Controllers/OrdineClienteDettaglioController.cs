using _20241024_GestioneMagazzino.Models.Dto;
using _20241024_GestioneMagazzino.Models.Entities;
using _20241024_GestioneMagazzino.Mappers;
using Microsoft.AspNetCore.Mvc;
using _20241024_GestioneMagazzino.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _20241024_GestioneMagazzino.Controllers
{
    [ApiController]
    [Route("OrdineClienteDettaglio")]
    public class OrdineClienteDettaglioController : ControllerBase
    {
        private readonly OrdineClienteDettaglioRepository _repository;

        public OrdineClienteDettaglioController(OrdineClienteDettaglioRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int? IdOrdineClienteTesta, [FromQuery] int? IdProdotto)
        {
            // Obtendo os detalhes de forma assíncrona
            var dettagli = await _repository.GetAllAsync(IdOrdineClienteTesta, IdProdotto);

            return Ok(dettagli);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var dettaglio = await _repository.GetByIdAsync(id);

            if (dettaglio == null)
                return NotFound();

            return Ok(OrdineClienteDettaglioMapper.Map(dettaglio));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] OrdineClienteDettaglioDto dto)
        {
            var entity = OrdineClienteDettaglioMapper.Map(dto);
            var result = await _repository.CreateAsync(entity);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, OrdineClienteDettaglioMapper.Map(result));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] OrdineClienteDettaglioDto dto)
        {
            try
            {
                var entity = OrdineClienteDettaglioMapper.Map(dto);
                var updatedEntity = await _repository.UpdateAsync(id, entity);
                return Ok(OrdineClienteDettaglioMapper.Map(updatedEntity));
            }
            catch (ArgumentException)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _repository.DeleteAsync(id);
                return NoContent();
            }
            catch (ArgumentException)
            {
                return NotFound();
            }
        }
    }
}
