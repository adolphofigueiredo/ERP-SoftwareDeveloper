using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_CoreWebApp_ModelViewControl.Controllers
{
    public class StudentiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Search()
        {
            return View();
        }
    }
}
