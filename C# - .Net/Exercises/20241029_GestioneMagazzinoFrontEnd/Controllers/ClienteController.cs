using _20241029_GestioneMagazzinoFrontEnd.Models;
using _20241029_GestioneMagazzinoFrontEnd.Models.Dto;
using _20241029_GestioneMagazzinoFrontEnd.Models.Entities;
using _20241029_GestioneMagazzinoFrontEnd.Models.Filters;
using _20241029_GestioneMagazzinoFrontEnd.Models.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace _20241029_GestioneMagazzinoFrontEnd.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> New(ClienteDto clienteDto)
        {
            if (ModelState.IsValid != true)
            {

                return View(clienteDto);

            }

            var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:7041"),
            };

            await httpClient.PostAsJsonAsync("Cliente", clienteDto);

            return Redirect(Url.Action(nameof(Index), "cliente"));
        }

        [HttpGet]
        public async Task<IActionResult> Index([FromQuery] ClienteFilter filter)
        {
            if (ModelState.IsValid != true)
            {

                return View(filter);

            }

            var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:7041"),
            };

            await httpClient.PostAsJsonAsync("Cliente", filter);

            return Redirect(Url.Action(nameof(Index), "index"));

            
        }
    }
    
}