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
    public class ClienteController : ControllerBase
    {
        private readonly ClienteRepository _clienteRepository;

        public ClienteController(ClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [HttpPost]
        public IActionResult Post([FromBody] ClienteDto clienteDto)
        {
            if (clienteDto == null)
            {
                return BadRequest("ClienteDto cannot be null.");
            }

            var clienteEntity = ClientiMapper.Map(clienteDto);
            _clienteRepository.Post(clienteEntity);

            return CreatedAtAction(nameof(GetById), new { id = clienteEntity.Id }, clienteDto);
        }

        [HttpGet]
        public IActionResult Get([FromQuery] ClienteFilter filter)
        {
            var clienteEntities = _clienteRepository.Find(filter);
            var clienteDtos = clienteEntities.Select(ClientiMapper.Map).ToList();
            return Ok(clienteDtos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)  // Certifique-se de que este método está presente
        {
            var clienteEntity = _clienteRepository.Get(id);
            if (clienteEntity == null)
            {
                return NotFound($"Cliente com ID {id} não encontrado.");
            }
            var clienteDto = ClientiMapper.Map(clienteEntity);
            return Ok(clienteDto);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ClienteDto clienteDto)
        {
            if (clienteDto == null)
            {
                return BadRequest("ClienteDto cannot be null.");
            }

            var clienteEntity = ClientiMapper.Map(clienteDto);

            try
            {
                var updatedCliente = _clienteRepository.Put(id, clienteEntity);
                return Ok(ClientiMapper.Map(updatedCliente));
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
                var deletedCliente = _clienteRepository.Delete(id);
                return Ok(ClientiMapper.Map(deletedCliente));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}