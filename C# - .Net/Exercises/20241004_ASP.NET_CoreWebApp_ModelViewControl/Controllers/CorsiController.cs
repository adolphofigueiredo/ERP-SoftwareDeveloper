using Microsoft.AspNetCore.Mvc;

namespace _20241004_ASP.NET_CoreWebApp_ModelViewControl.Controllers
{
    public class CorsiController : Controller              //O CorsiController é um controller que lida com as ações que
                                                           //o usuário pode executar em relação aos cursos. Ele herda
                                                           //de Controller, que é a classe base para todos os controladores
                                                           //no ASP.NET Core MVC. Esta classe fornece vários métodos e
                                                           //funcionalidades que facilitam o processamento de requisições HTTP.
    {
        public IActionResult Index()                       //O método index geralmente corresponde à rota padrão de um controller
                                                           //(exemplo: /Corsi/Index ou simplesmente /Corsi). O método
                                                           //retorna uma View(), que indica ao framework para renderizar uma View
                                                           //associada ao método. No caso de Index, a View provavelmente se chamará
                                                           //Index.cshtml e será localizada na pasta Views/Corsi.
        {
            return View();                                 //Se a View (como Index.cshtml e Search.cshtml) estiver corretamente
                                                           //configurada na pasta Views/Studenti/, elas serão exibidas quando
                                                           //as ações forem chamadas.
        }
    }
}
