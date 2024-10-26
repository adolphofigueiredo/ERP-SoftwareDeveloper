using _20241024_GestioneMagazzino.Models;
using _20241024_GestioneMagazzino.Models.Dto;
using _20241024_GestioneMagazzino.Models.Entities;
using _20241024_GestioneMagazzino.Models.Filters;
using _20241024_GestioneMagazzino.Models.Mappers;
using _20241024_GestioneMagazzino.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _20241024_GestioneMagazzino.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteRepository _clienteRepository;

        public ClienteController(ClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public IActionResult Index([FromQuery] ClienteFilter filter)
        {
            var elementiTrovati = _clienteRepository.Find(filter);

            List <ClienteDto> clientiDto = elementiTrovati
                .Select(r => ClienteMapper.Map(r))
                .ToList();

            return View(new ClientiIndexViewModel()
            {
                Filter = filter,
                ElementiTrovati = clientiDto,
            });
        }
        public IActionResult Aggiungi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Aggiungi(ClienteDto clienteDto)
        {
            if (ModelState.IsValid != true)
            {
                return View(clienteDto);
            }

            _clienteRepository.Post(ClienteMapper.Map(clienteDto));
            return Redirect(Url.Action(nameof(Index),"clienti"));

        }
    }
}
