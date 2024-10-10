using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models;
using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Repositories;
using Microsoft.EntityFrameworkCore;

internal class Program                                               //Define uma classe chamada Program, que � a classe principal da aplica��o.
                                                                     //O modificador de acesso internal significa que a classe � acess�vel apenas
                                                                     //dentro do mesmo assembly.
{   
    private static void Main(string[] args)                          //Define o m�todo Main, que � o ponto de entrada da aplica��o. O m�todo �
                                                                     //est�tico, o que significa que ele pertence � classe e n�o a uma inst�ncia
                                                                     //da classe. O string[] args permite que argumentos sejam passados para a
                                                                     //aplica��o a partir da linha de comando. Esses argumentos podem ser usados
                                                                     //para alterar o comportamento da aplica��o ao inici�-la.
	{
        var builder = WebApplication.CreateBuilder(args);            //Esta linha cria uma inst�ncia de WebApplicationBuilder, que � usada para
                                                                     //configurar e construir a aplica��o ASP.NET Core. O CreateBuilder(args) �
                                                                     //o m�todo que aceita um array de strings como argumento, que representa os
                                                                     //par�metros de linha de comando. Essa configura��o inicializa a aplica��o
                                                                     //com as op��es padr�o, permitindo que voc� adicione servi�os e configura��es
                                                                     //necess�rias antes de construir a aplica��o.
				// Add services to the container.
				builder.Services.AddControllersWithViews();          //O builder.Services.AddControllersWithViews(); registra os servi�os
                                                                     //necess�rios para suportar controladores e views em uma aplica��o MVC. Isso
                                                                     //permite que a aplica��o responda a requisi��es HTTP com a��es de controladores
                                                                     //e renderize views correspondentes. Sem essa linha, a aplica��o n�o conseguiria
                                                                     //atender a requisi��es para p�ginas web.

		builder.Services.AddDbContext<ItsCorsiEsamiContext>(         //Adiciona o contexto de banco de dados ItsCorsiEsamiContext ao cont�iner de
                                                                     //inje��o de depend�ncia. O DbContext � uma classe que representa uma sess�o
                                                                     //com o banco de dados, permitindo realizar opera��es CRUD(Create, Read, Update, Delete).
			dbContextOptionsBuilder =>                               //Define uma fun��o lambda para configurar as op��es do contexto de banco de dados.
			{
                string connectionString = builder.Configuration.GetConnectionString("ITSEsempiDB");
                dbContextOptionsBuilder.UseSqlServer(connectionString);
            });                                                      //O string connectionString = builder.Configuration.GetConnectionString("ITSEsempidb");
																	 //Obt�m a string de conex�o chamada "ITSEsempiDB" do arquivo de configura��o (geralmente
																	 //appsettings.json). A string de conex�o cont�m informa��es sobre como conectar-se ao
																	 //banco de dados, incluindo o servidor, nome do banco de dados e credenciais.
																	 //O dbContextOptionsBuilder.UseSqlServer(connectionString); configura o Entity Framework
                                                                     //Core para usar o SQL Server como provedor de banco de dados. A string de conex�o obtida
                                                                     //anteriormente � passada para configurar a conex�o.

		builder.Services.AddScoped<StudentiRepository>();            //Registra a classe StudentiRepository como um servi�o com ciclo de vida "scoped". Isso
                                                                     //significa que uma nova inst�ncia do reposit�rio ser� criada para cada solicita��o HTTP.
                                                                     //O reposit�rio � respons�vel por encapsular a l�gica de acesso a dados, permitindo que
                                                                     //voc� acesse os dados da entidade Studente de forma abstrata, facilitando a manuten��o
                                                                     //e o teste da aplica��o.
		
        var app = builder.Build();                                   //Constr�i a aplica��o usando as configura��es e servi�os que foram definidos. O objeto
                                                                     //app agora representa a aplica��o ASP.NET Core, pronta para ser configurada para tratar
                                                                     //solicita��es.

		// Configure the HTTP request pipeline.
		if (!app.Environment.IsDevelopment())                        //Verifica se o ambiente atual n�o � de desenvolvimento.
		{
            app.UseExceptionHandler("/Home/Error");                  //Configura um manipulador de exce��es global. Se uma exce��o n�o tratada ocorrer durante
                                                                     //o processamento de uma solicita��o, o usu�rio ser� redirecionado para a p�gina de erro / 
                                                                     //Home / Error. Isso ajuda a melhorar a experi�ncia do usu�rio, apresentando uma p�gina
                                                                     //amig�vel em vez de uma mensagem de erro do servidor.

						// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
						app.UseHsts();                               //O HSTS � uma pol�tica de seguran�a que informa aos navegadores que devem se conectar
                                                                     //ao servidor apenas por HTTPS. Isso � importante para proteger a aplica��o contra ataques
                                                                     //de downgrade e outras amea�as de seguran�a.   
		}

        app.UseHttpsRedirection();                                   //Habilita o redirecionamento de HTTP para HTTPS. Qualquer solicita��o recebida por HTTP
                                                                     //ser� automaticamente redirecionada para HTTPS, garantindo que todas as comunica��es
                                                                     //sejam feitas de forma segura.

				app.UseStaticFiles();                                //Permite que a aplica��o sirva arquivos est�ticos, como imagens, CSS e JavaScript. Os
                                                                     //arquivos est�ticos s�o aqueles que n�o mudam com frequ�ncia e podem ser entregues diretamente
                                                                     //ao cliente. Essa linha � essencial para o funcionamento de qualquer frontend que dependa de recursos est�ticos.

				app.UseRouting();                                    //Habilita o roteamento na aplica��o. O roteamento � a funcionalidade que mapeia as URLs das
                                                                     //solicita��es para os m�todos dos controladores apropriados. Essa linha deve ser chamada
                                                                     //antes de definir as permiss�es de autoriza��o ou mapear rotas, garantindo que o ASP.NET
                                                                     //Core possa reconhecer as solicita��es que chegam.

		app.UseAuthorization();                                      //Ativa o middleware de autoriza��o. Essa linha verifica se o usu�rio tem permiss�o para
                                                                     //acessar recursos ou executar a��es espec�ficas, conforme configurado nas pol�ticas de
                                                                     //autoriza��o da aplica��o.

		app.MapControllerRoute(                                      //Define uma rota padr�o para a aplica��o. Isso estabelece como as URLs ser�o mapeadas para
                                                                     //os controladores e suas a��es.

			name: "default",                                         //Define o nome da rota, que pode ser usado para refer�ncia.
			pattern: "{controller=Home}/{action=Index}/{id?}");      //Define o padr�o de rota que descreve como a URL ser� estruturada. O {controller = Home}
                                                                     //diz que se o nome do controlador n�o for especificado na URL, Home ser� usado como o
                                                                     //controlador padr�o. O {action = Index} diz que se o nome da a��o n�o for especificado,
                                                                     //Index ser� a a��o padr�o a ser executada. O {id ?} diz que o par�metro id � opcional,
                                                                     //indicado pelo ?. Isso permite que a rota funcione corretamente, mesmo se nenhum ID for fornecido na URL.

		app.Run();                                                   //Inicia a aplica��o ASP.NET Core. Este m�todo faz com que a aplica��o comece a escutar
                                                                     //solicita��es HTTP e execute o pipeline de middleware que foi configurado. Ap�s esta
                                                                     //chamada, a aplica��o est� pronta para receber e processar requisi��es.
	}
}

//builder.Services.AddScoped<>();
//builder.Services.AddTransient<>();
//builder.Services.AddSingleton<>();


//Padr�es de Arquitetura de Projetos

//Cada um desses padr�es e arquiteturas tem seu uso espec�fico e ajuda a organizar melhor o c�digo,
//al�m de facilitar a manuten��o e a escalabilidade da aplica��o.
//O MVC e MVVM s�o arquiteturas que organizam o c�digo em camadas separadas.
//O IoC � um princ�pio para gerir depend�ncias e injet�-las automaticamente.
//O Abstract Factory e Singleton s�o padr�es criacionais, usados para gerenciar a cria��o de objetos.
//O Repository Pattern � usado para encapsular o acesso aos dados e a l�gica de persist�ncia,
//separando-o da l�gica de neg�cios.

//1. MVC (Model-View-Controller)
//Arquitetura: O padr�o MVC � uma arquitetura usada para separar as preocupa��es de uma aplica��o em
//tr�s componentes principais:
//Model: Representa os dados e a l�gica do neg�cio. � respons�vel por recuperar, manipular e armazenar
//os dados (geralmente de um banco de dados).
//View: Define a interface com o usu�rio e � respons�vel por apresentar os dados ao usu�rio, obtidos
//do Model. A View recebe os dados do Controller.
//Controller: Age como um intermedi�rio entre a View e o Model. Ele processa a entrada do usu�rio,
//faz chamadas ao Model e retorna os dados atualizados � View.
//Exemplo: No ASP.NET Core, o Controller recebe uma requisi��o HTTP, manipula os dados (Model),
//e passa a resposta � View, que renderiza o HTML.

//2. IoC (Inversion of Control)
//Padr�o de Projeto (Design Pattern): O IoC � um princ�pio que inverte o controle do fluxo de uma
//aplica��o. No contexto de inje��o de depend�ncia, o IoC permite que um container ou framework
//forne�a as depend�ncias de uma classe em vez da pr�pria classe instanciar suas depend�ncias diretamente.
//Exemplo de uso: Em ASP.NET Core, o IoC Container � integrado, e voc� registra servi�os e suas
//depend�ncias na Startup.cs com o m�todo ConfigureServices. Esses servi�os s�o injetados em classes
//(como Controllers) automaticamente.

//3. MVVM (Model-View-ViewModel)
//Arquitetura: O padr�o MVVM � uma evolu��o do MVC usada principalmente em aplica��es que t�m uma
//interface rica, como WPF ou aplicativos m�veis.
//Model: Como no MVC, representa os dados e a l�gica do neg�cio.
//View: Define a interface gr�fica, como os controles visuais e elementos de UI.
//ViewModel: A ponte entre o Model e a View. Ele exp�e os dados do Model � View e gerencia as
//intera��es com a UI. A diferen�a principal do Controller do MVC � que o ViewModel frequentemente
//interage com Bindings que permitem atualiza��o autom�tica da interface gr�fica quando os dados mudam.
//Exemplo: No WPF (Windows Presentation Foundation), o ViewModel comunica-se diretamente com a View
//atrav�s de data-binding, tornando poss�vel que a UI se atualize quando os dados mudam.

//4. Abstract Factory (F�brica Abstrata)
//Padr�o de Projeto (Design Pattern): O Abstract Factory � um padr�o criacional que fornece uma
//interface para criar fam�lias de objetos relacionados ou dependentes sem especificar suas
//classes concretas. Isso permite que o c�digo cliente utilize uma "f�brica" para instanciar
//objetos de diferentes fam�lias de produtos.
//
// public interface IVehicleFactory
// {
// Car CreateCar();
// Bike CreateBike();
// }
//
// public class TeslaFactory : IVehicleFactory
// {
// public Car CreateCar() => new TeslaCar();
// public Bike CreateBike() => new TeslaBike();
// }

//5. Singleton
//Padr�o de Projeto (Design Pattern): O Singleton � um padr�o que garante que uma classe tenha
//apenas uma �nica inst�ncia e fornece um ponto global de acesso a essa inst�ncia.
//
// public class Singleton
// {
// 
// private static Singleton _instance;
// 
// private Singleton() { }
// 
// public static Singleton Instance
// {
// get
// {
// if (_instance == null)
// _instance = new Singleton();
// return _instance;
// }
// }
// }
// Este padr�o � �til em situa��es em que � necess�rio ter exatamente uma inst�ncia de um objeto
// compartilhada em toda a aplica��o (ex: gerenciamento de cache, configura��es globais).

// 6. Repository Pattern (Padr�o Reposit�rio)
// Padr�o de Projeto (Design Pattern): O Repository Pattern isola a l�gica de acesso a dados da
// l�gica de neg�cio. Ele atua como um intermedi�rio entre a aplica��o e a fonte de dados (como
// um banco de dados), fornecendo uma interface comum para acesso e manipula��o dos dados.
// 
// public interface IStudentRepository
// {
// IEnumerable<Student> GetAll();
// Student GetById(int id);
// void Add(Student student);
// void Delete(int id);
// }
// 
// public class StudentRepository : IStudentRepository
// {
// private readonly DbContext _context;
// 
// public StudentRepository(DbContext context)
// {
// _context = context;
// }
// 
// public IEnumerable<Student> GetAll()
// {
// return _context.Students.ToList();
// }
// 
// public Student GetById(int id)
// {
// return _context.Students.Find(id);
// }
// 
// public void Add(Student student)
// {
// _context.Students.Add(student);
// _context.SaveChanges();
// }
// 
// public void Delete(int id)
// {
// var student = _context.Students.Find(id);
// if (student != null)
// {
// _context.Students.Remove(student);
// _context.SaveChanges();
// }
//     }
// }
// Este padr�o permite que voc� tenha uma camada intermedi�ria entre a l�gica de neg�cios e a
// fonte de dados, facilitando a manuten��o e teste da aplica��o.