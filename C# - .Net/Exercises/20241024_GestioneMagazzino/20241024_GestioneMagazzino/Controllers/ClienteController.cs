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
        public IActionResult Post(ClienteDto clienteDto)
        {
            var clienteEntity = ClientiMapper.From(clienteDto);
            _clienteRepository.Post(clienteEntity);
            return Ok();
        }
        
    }
}
