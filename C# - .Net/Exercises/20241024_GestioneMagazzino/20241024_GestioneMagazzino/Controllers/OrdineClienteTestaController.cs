using _20241024_GestioneMagazzino.Models.Dto;
using _20241024_GestioneMagazzino.Models.Entities;
using _20241024_GestioneMagazzino.Models.Filters;
using _20241024_GestioneMagazzino.Mappers;
using _20241024_GestioneMagazzino.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _20241024_GestioneMagazzino.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdineClienteController : ControllerBase
    {
        private readonly OrdineClienteTestaRepository _repository;

        public OrdineClienteController(OrdineClienteTestaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] OrdineClienteTestaFilter filter)
        {
            var result = await _repository.GetFilteredAsync(filter);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult<OrdineClienteTestaDto> GetById(int id)
        {
            var ordine = _repository.GetById(id);
            if (ordine == null)
                return NotFound();

            return Ok(OrdineClienteTestaMapper.Map(ordine));
        }

        [HttpPost]
        public ActionResult<OrdineClienteTestaDto> Create(OrdineClienteTestaDto dto)
        {
            var ordine = OrdineClienteTestaMapper.Map(dto);
            var createdOrdine = _repository.Create(ordine);
            return CreatedAtAction(nameof(GetById), new { id = createdOrdine.Id }, OrdineClienteTestaMapper.Map(createdOrdine));
        }

        [HttpPut("{id}")]
        public ActionResult<OrdineClienteTestaDto> Update(int id, OrdineClienteTestaDto dto)
        {
            var ordine = OrdineClienteTestaMapper.Map(dto);
            var updatedOrdine = _repository.Update(id, ordine);
            return Ok(OrdineClienteTestaMapper.Map(updatedOrdine));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _repository.Delete(id);
            return NoContent();
        }
    }
}
