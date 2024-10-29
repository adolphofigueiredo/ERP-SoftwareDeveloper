using _20241029_GestioneMagazzinoFrontEnd.Models;
using _20241029_GestioneMagazzinoFrontEnd.Models.Dto;
using _20241029_GestioneMagazzinoFrontEnd.Models.Entities;
using _20241029_GestioneMagazzinoFrontEnd.Models.Filters;
using _20241029_GestioneMagazzinoFrontEnd.Models.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace _20241029_GestioneMagazzinoFrontEnd.Controllers
{
    public class ProdottoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult New()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> New(ProdottoDto prodottoDto)
        {
            if (ModelState.IsValid != true)
            {

                return View(prodottoDto);

            }

            var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:7041"),
            };

            await httpClient.PostAsJsonAsync("Prodotto", prodottoDto);

            return Redirect(Url.Action(nameof(Index), "prodotto"));
        }
    }
}