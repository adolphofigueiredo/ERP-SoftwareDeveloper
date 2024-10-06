using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _20241004_ASP.NET_CoreWebApp_ModelViewControl.Controllers
{
    public class HomeController : Controller                         //O HomeController herda da classe Controller, que é uma
                                                                     //classe base fornecida pelo framework ASP.NET Core MVC.
                                                                     //Ela contém muitos dos métodos e propriedades essenciais
                                                                     //para o processamento de requisições HTTP e geração de respostas.
                                                                     //Ele é um controller que lida com as ações que o usuário
                                                                     //pode executar em relação a Home. Ele herda de Controller,
                                                                     //que é a classe base para todos os controladores no ASP.NET
                                                                     //Core MVC. Esta classe fornece vários métodos e funcionalidades
                                                                     //que facilitam o processamento de requisições HTTP.
    {
        private readonly ILogger<HomeController> _logger;            //A variável _logger é privada, o que significa que ela só pode
                                                                     //ser acessada dentro da classe HomeController.Não pode ser usada
                                                                     //ou acessada diretamente por outras classes. O readonly indica
                                                                     //que a variável _logger só pode ser atribuída uma vez, normalmente
                                                                     //no momento da inicialização (dentro do construtor da classe).
                                                                     //Após isso, seu valor não pode ser modificado. Isso é útil para
                                                                     //garantir que o logger não seja inadvertidamente alterado ao
                                                                     //longo do ciclo de vida do objeto. O ILogger<HomeController> diz
                                                                     //que o tipo de _logger é ILogger<HomeController>. ILogger é
                                                                     //uma interface que faz parte do sistema de logging do .NET,
                                                                     //usada para registrar mensagens, erros e outras informações
                                                                     //úteis sobre o comportamento da aplicação. O uso de
                                                                     //ILogger<HomeController> indica que o logger é especializado
                                                                     //em registrar mensagens associadas à classe HomeController. O
                                                                     //_logger é o nome da variável privada que armazena a instância
                                                                     //de ILogger. O uso do prefixo _ é uma convenção comum para
                                                                     //variáveis de instância privadas em C#.

        public HomeController(ILogger<HomeController> logger)        //O construtor recebe um logger (um objeto que implementa a
                                                                     //interface ILogger), que é injetado automaticamente no momento
                                                                     //da criação do controlador. ILogger<HomeController>: Um logger
                                                                     //especializado para registrar mensagens relacionadas ao HomeController.
                                                                     //O sistema de log ajuda a rastrear o comportamento da aplicação
                                                                     //durante sua execução, especialmente para fins de depuração e monitoramento.
        {
            _logger = logger;                                        //Significa que o valor do parâmetro logger (que é passado ao
                                                                     //construtor HomeController) está sendo atribuído à variável
                                                                     //privada e somente leitura _logger. No construtor da classe
                                                                     //HomeController, o parâmetro logger é do tipo ILogger<HomeController>.
                                                                     //Este parâmetro é injetado pelo sistema de Injeção de Dependência
                                                                     //(Dependency Injection) do ASP.NET Core. O framework fornece
                                                                     //automaticamente uma instância de ILogger<HomeController> ao
                                                                     //criar o controlador. Essa atribuição permite que _logger seja
                                                                     //usado em toda a classe HomeController para registrar logs.
                                                                     //Como _logger é uma variável de instância(declarada fora do
                                                                     //construtor e usada em qualquer parte da classe), a instância
                                                                     //injetada de ILogger<HomeController> é armazenada nela para que
                                                                     //métodos da classe possam utilizá-la.
        }

        public IActionResult Index()                                 //Esses métodos são responsáveis por lidar com diferentes requisições
                                                                     //HTTP que a aplicação recebe e por devolver as respostas apropriadas.
                                                                     //A public IActionResult Index() é a interface que representa o
                                                                     //resultado de uma ação do controlador. Pode ser uma View(), um
                                                                     //Redirect(), um JsonResult(), entre outros. O return View() retorna
                                                                     //a View associada ao método Index.O ASP.NET Core procurará a view
                                                                     //correspondente no diretório Views/Home/Index.cshtml. Este método
                                                                     //lida com a requisição para a página inicial da aplicação (geralmente
                                                                     //acessada pela rota / ou /Home/Index).
        {
            return View();
        }

        public IActionResult Privacy()                               //Semelhante ao método Index(), este retorna a view associada à página
                                                                     //de privacidade, geralmente acessada pela rota /Home/Privacy. O ASP.NET
                                                                     //Core vai procurar pela view Views/Home/Privacy.cshtml.
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
                                                                     //O [ResponseCache(...)] é uma anotação que controla como as respostas
                                                                     //dessa ação são armazenadas em cache. Aqui, o cache é desativado
                                                                     //completamente com Duration = 0, NoStore = true e Location = None.
                                                                     //Isso garante que as páginas de erro nunca sejam armazenadas em cache,
                                                                     //o que é importante para garantir que sempre reflitam o erro atual.
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
                                                                     //O Activity.Current?.Id faz parte do namespace System.Diagnostics e é
                                                                     //usado para rastrear a execução da aplicação.
                                                                     //O Activity.Current captura a atividade atual, e Activity.Current?.Id
                                                                     //obtém o ID da requisição atual. Já o HttpContext.TraceIdentifier, se o
                                                                     //ID da atividade estiver null, o TraceIdentifier da requisição HTTP
                                                                     //(um identificador único) é utilizado no lugar.
                                                                     //O View(new ErrorViewModel { RequestId = ... }); cria um objeto
                                                                     //ErrorViewModel e o passa para a view Error.cshtml.Este modelo contém
                                                                     //o RequestId, que pode ser exibido na página de erro para ajudar no
                                                                     //rastreamento do problema.
        }
    }
}
