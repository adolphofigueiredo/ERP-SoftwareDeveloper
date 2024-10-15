using BibliotecaWebService.Models;
using BibliotecaWebService.Models.Dtos;
using BibliotecaWebService.Models.Filters;
using BibliotecaWebService.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaWebService.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ClientiController : ControllerBase
	{
		private readonly ClienteRepository _clienteRepository;

		public ClientiController(ClienteRepository clienteRepository)
		{
			_clienteRepository = clienteRepository;
		}

		[HttpPost]
		public IActionResult Post(ClienteDto clienteDto)
		{
			var clienteEntity = ClientiMapper.From(clienteDto);
			_clienteRepository.Insert(clienteEntity);
			return Ok();
		}

		[HttpGet]
		[Route("{codiceFiscale}")]
		public IActionResult Get(string codiceFiscale)
		{
			throw new NotImplementedException();
		}

		[HttpGet]
		public IActionResult Get([FromQuery] ClienteFilter filter)
		{
			throw new NotImplementedException();
		}

		[HttpGet]
		[Route("[action]")]
		public IActionResult Count([FromQuery] ClienteFilter filter)
		{
			throw new NotImplementedException();
		}

		[HttpPut]
		public IActionResult Put(string codiceFiscale, ClienteDto newValue)
		{
			throw new NotImplementedException();
		}

		[HttpDelete]
		public IActionResult Delete(string codiceFiscale)
		{
			throw new NotImplementedException();
		}

	}
}
