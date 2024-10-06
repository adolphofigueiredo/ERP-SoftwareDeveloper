using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _20241004_ASP.NET_CoreWebApp_ModelViewControl.Controllers
{
    public class HomeController : Controller                         //O HomeController herda da classe Controller, que � uma
                                                                     //classe base fornecida pelo framework ASP.NET Core MVC.
                                                                     //Ela cont�m muitos dos m�todos e propriedades essenciais
                                                                     //para o processamento de requisi��es HTTP e gera��o de respostas.
                                                                     //Ele � um controller que lida com as a��es que o usu�rio
                                                                     //pode executar em rela��o a Home. Ele herda de Controller,
                                                                     //que � a classe base para todos os controladores no ASP.NET
                                                                     //Core MVC. Esta classe fornece v�rios m�todos e funcionalidades
                                                                     //que facilitam o processamento de requisi��es HTTP.
    {
        private readonly ILogger<HomeController> _logger;            //A vari�vel _logger � privada, o que significa que ela s� pode
                                                                     //ser acessada dentro da classe HomeController.N�o pode ser usada
                                                                     //ou acessada diretamente por outras classes. O readonly indica
                                                                     //que a vari�vel _logger s� pode ser atribu�da uma vez, normalmente
                                                                     //no momento da inicializa��o (dentro do construtor da classe).
                                                                     //Ap�s isso, seu valor n�o pode ser modificado. Isso � �til para
                                                                     //garantir que o logger n�o seja inadvertidamente alterado ao
                                                                     //longo do ciclo de vida do objeto. O ILogger<HomeController> diz
                                                                     //que o tipo de _logger � ILogger<HomeController>. ILogger �
                                                                     //uma interface que faz parte do sistema de logging do .NET,
                                                                     //usada para registrar mensagens, erros e outras informa��es
                                                                     //�teis sobre o comportamento da aplica��o. O uso de
                                                                     //ILogger<HomeController> indica que o logger � especializado
                                                                     //em registrar mensagens associadas � classe HomeController. O
                                                                     //_logger � o nome da vari�vel privada que armazena a inst�ncia
                                                                     //de ILogger. O uso do prefixo _ � uma conven��o comum para
                                                                     //vari�veis de inst�ncia privadas em C#.

        public HomeController(ILogger<HomeController> logger)        //O construtor recebe um logger (um objeto que implementa a
                                                                     //interface ILogger), que � injetado automaticamente no momento
                                                                     //da cria��o do controlador. ILogger<HomeController>: Um logger
                                                                     //especializado para registrar mensagens relacionadas ao HomeController.
                                                                     //O sistema de log ajuda a rastrear o comportamento da aplica��o
                                                                     //durante sua execu��o, especialmente para fins de depura��o e monitoramento.
        {
            _logger = logger;                                        //Significa que o valor do par�metro logger (que � passado ao
                                                                     //construtor HomeController) est� sendo atribu�do � vari�vel
                                                                     //privada e somente leitura _logger. No construtor da classe
                                                                     //HomeController, o par�metro logger � do tipo ILogger<HomeController>.
                                                                     //Este par�metro � injetado pelo sistema de Inje��o de Depend�ncia
                                                                     //(Dependency Injection) do ASP.NET Core. O framework fornece
                                                                     //automaticamente uma inst�ncia de ILogger<HomeController> ao
                                                                     //criar o controlador. Essa atribui��o permite que _logger seja
                                                                     //usado em toda a classe HomeController para registrar logs.
                                                                     //Como _logger � uma vari�vel de inst�ncia(declarada fora do
                                                                     //construtor e usada em qualquer parte da classe), a inst�ncia
                                                                     //injetada de ILogger<HomeController> � armazenada nela para que
                                                                     //m�todos da classe possam utiliz�-la.
        }

        public IActionResult Index()                                 //Esses m�todos s�o respons�veis por lidar com diferentes requisi��es
                                                                     //HTTP que a aplica��o recebe e por devolver as respostas apropriadas.
                                                                     //A public IActionResult Index() � a interface que representa o
                                                                     //resultado de uma a��o do controlador. Pode ser uma View(), um
                                                                     //Redirect(), um JsonResult(), entre outros. O return View() retorna
                                                                     //a View associada ao m�todo Index.O ASP.NET Core procurar� a view
                                                                     //correspondente no diret�rio Views/Home/Index.cshtml. Este m�todo
                                                                     //lida com a requisi��o para a p�gina inicial da aplica��o (geralmente
                                                                     //acessada pela rota / ou /Home/Index).
        {
            return View();
        }

        public IActionResult Privacy()                               //Semelhante ao m�todo Index(), este retorna a view associada � p�gina
                                                                     //de privacidade, geralmente acessada pela rota /Home/Privacy. O ASP.NET
                                                                     //Core vai procurar pela view Views/Home/Privacy.cshtml.
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
                                                                     //O [ResponseCache(...)] � uma anota��o que controla como as respostas
                                                                     //dessa a��o s�o armazenadas em cache. Aqui, o cache � desativado
                                                                     //completamente com Duration = 0, NoStore = true e Location = None.
                                                                     //Isso garante que as p�ginas de erro nunca sejam armazenadas em cache,
                                                                     //o que � importante para garantir que sempre reflitam o erro atual.
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
                                                                     //O Activity.Current?.Id faz parte do namespace System.Diagnostics e �
                                                                     //usado para rastrear a execu��o da aplica��o.
                                                                     //O Activity.Current captura a atividade atual, e Activity.Current?.Id
                                                                     //obt�m o ID da requisi��o atual. J� o HttpContext.TraceIdentifier, se o
                                                                     //ID da atividade estiver null, o TraceIdentifier da requisi��o HTTP
                                                                     //(um identificador �nico) � utilizado no lugar.
                                                                     //O View(new ErrorViewModel { RequestId = ... }); cria um objeto
                                                                     //ErrorViewModel e o passa para a view Error.cshtml.Este modelo cont�m
                                                                     //o RequestId, que pode ser exibido na p�gina de erro para ajudar no
                                                                     //rastreamento do problema.
        }
    }
}
