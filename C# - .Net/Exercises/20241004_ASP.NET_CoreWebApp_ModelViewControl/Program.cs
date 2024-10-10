using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models;
using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Repositories;
using Microsoft.EntityFrameworkCore;

internal class Program                                               //Define uma classe chamada Program, que é a classe principal da aplicação.
                                                                     //O modificador de acesso internal significa que a classe é acessível apenas
                                                                     //dentro do mesmo assembly.
{   
    private static void Main(string[] args)                          //Define o método Main, que é o ponto de entrada da aplicação. O método é
                                                                     //estático, o que significa que ele pertence à classe e não a uma instância
                                                                     //da classe. O string[] args permite que argumentos sejam passados para a
                                                                     //aplicação a partir da linha de comando. Esses argumentos podem ser usados
                                                                     //para alterar o comportamento da aplicação ao iniciá-la.
	{
        var builder = WebApplication.CreateBuilder(args);            //Esta linha cria uma instância de WebApplicationBuilder, que é usada para
                                                                     //configurar e construir a aplicação ASP.NET Core. O CreateBuilder(args) é
                                                                     //o método que aceita um array de strings como argumento, que representa os
                                                                     //parâmetros de linha de comando. Essa configuração inicializa a aplicação
                                                                     //com as opções padrão, permitindo que você adicione serviços e configurações
                                                                     //necessárias antes de construir a aplicação.
				// Add services to the container.
				builder.Services.AddControllersWithViews();          //O builder.Services.AddControllersWithViews(); registra os serviços
                                                                     //necessários para suportar controladores e views em uma aplicação MVC. Isso
                                                                     //permite que a aplicação responda a requisições HTTP com ações de controladores
                                                                     //e renderize views correspondentes. Sem essa linha, a aplicação não conseguiria
                                                                     //atender a requisições para páginas web.

		builder.Services.AddDbContext<ItsCorsiEsamiContext>(         //Adiciona o contexto de banco de dados ItsCorsiEsamiContext ao contêiner de
                                                                     //injeção de dependência. O DbContext é uma classe que representa uma sessão
                                                                     //com o banco de dados, permitindo realizar operações CRUD(Create, Read, Update, Delete).
			dbContextOptionsBuilder =>                               //Define uma função lambda para configurar as opções do contexto de banco de dados.
			{
                string connectionString = builder.Configuration.GetConnectionString("ITSEsempiDB");
                dbContextOptionsBuilder.UseSqlServer(connectionString);
            });                                                      //O string connectionString = builder.Configuration.GetConnectionString("ITSEsempidb");
																	 //Obtém a string de conexão chamada "ITSEsempiDB" do arquivo de configuração (geralmente
																	 //appsettings.json). A string de conexão contém informações sobre como conectar-se ao
																	 //banco de dados, incluindo o servidor, nome do banco de dados e credenciais.
																	 //O dbContextOptionsBuilder.UseSqlServer(connectionString); configura o Entity Framework
                                                                     //Core para usar o SQL Server como provedor de banco de dados. A string de conexão obtida
                                                                     //anteriormente é passada para configurar a conexão.

		builder.Services.AddScoped<StudentiRepository>();            //Registra a classe StudentiRepository como um serviço com ciclo de vida "scoped". Isso
                                                                     //significa que uma nova instância do repositório será criada para cada solicitação HTTP.
                                                                     //O repositório é responsável por encapsular a lógica de acesso a dados, permitindo que
                                                                     //você acesse os dados da entidade Studente de forma abstrata, facilitando a manutenção
                                                                     //e o teste da aplicação.
		
        var app = builder.Build();                                   //Constrói a aplicação usando as configurações e serviços que foram definidos. O objeto
                                                                     //app agora representa a aplicação ASP.NET Core, pronta para ser configurada para tratar
                                                                     //solicitações.

		// Configure the HTTP request pipeline.
		if (!app.Environment.IsDevelopment())                        //Verifica se o ambiente atual não é de desenvolvimento.
		{
            app.UseExceptionHandler("/Home/Error");                  //Configura um manipulador de exceções global. Se uma exceção não tratada ocorrer durante
                                                                     //o processamento de uma solicitação, o usuário será redirecionado para a página de erro / 
                                                                     //Home / Error. Isso ajuda a melhorar a experiência do usuário, apresentando uma página
                                                                     //amigável em vez de uma mensagem de erro do servidor.

						// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
						app.UseHsts();                               //O HSTS é uma política de segurança que informa aos navegadores que devem se conectar
                                                                     //ao servidor apenas por HTTPS. Isso é importante para proteger a aplicação contra ataques
                                                                     //de downgrade e outras ameaças de segurança.   
		}

        app.UseHttpsRedirection();                                   //Habilita o redirecionamento de HTTP para HTTPS. Qualquer solicitação recebida por HTTP
                                                                     //será automaticamente redirecionada para HTTPS, garantindo que todas as comunicações
                                                                     //sejam feitas de forma segura.

				app.UseStaticFiles();                                //Permite que a aplicação sirva arquivos estáticos, como imagens, CSS e JavaScript. Os
                                                                     //arquivos estáticos são aqueles que não mudam com frequência e podem ser entregues diretamente
                                                                     //ao cliente. Essa linha é essencial para o funcionamento de qualquer frontend que dependa de recursos estáticos.

				app.UseRouting();                                    //Habilita o roteamento na aplicação. O roteamento é a funcionalidade que mapeia as URLs das
                                                                     //solicitações para os métodos dos controladores apropriados. Essa linha deve ser chamada
                                                                     //antes de definir as permissões de autorização ou mapear rotas, garantindo que o ASP.NET
                                                                     //Core possa reconhecer as solicitações que chegam.

		app.UseAuthorization();                                      //Ativa o middleware de autorização. Essa linha verifica se o usuário tem permissão para
                                                                     //acessar recursos ou executar ações específicas, conforme configurado nas políticas de
                                                                     //autorização da aplicação.

		app.MapControllerRoute(                                      //Define uma rota padrão para a aplicação. Isso estabelece como as URLs serão mapeadas para
                                                                     //os controladores e suas ações.

			name: "default",                                         //Define o nome da rota, que pode ser usado para referência.
			pattern: "{controller=Home}/{action=Index}/{id?}");      //Define o padrão de rota que descreve como a URL será estruturada. O {controller = Home}
                                                                     //diz que se o nome do controlador não for especificado na URL, Home será usado como o
                                                                     //controlador padrão. O {action = Index} diz que se o nome da ação não for especificado,
                                                                     //Index será a ação padrão a ser executada. O {id ?} diz que o parâmetro id é opcional,
                                                                     //indicado pelo ?. Isso permite que a rota funcione corretamente, mesmo se nenhum ID for fornecido na URL.

		app.Run();                                                   //Inicia a aplicação ASP.NET Core. Este método faz com que a aplicação comece a escutar
                                                                     //solicitações HTTP e execute o pipeline de middleware que foi configurado. Após esta
                                                                     //chamada, a aplicação está pronta para receber e processar requisições.
	}
}

//builder.Services.AddScoped<>();
//builder.Services.AddTransient<>();
//builder.Services.AddSingleton<>();


//Padrões de Arquitetura de Projetos

//Cada um desses padrões e arquiteturas tem seu uso específico e ajuda a organizar melhor o código,
//além de facilitar a manutenção e a escalabilidade da aplicação.
//O MVC e MVVM são arquiteturas que organizam o código em camadas separadas.
//O IoC é um princípio para gerir dependências e injetá-las automaticamente.
//O Abstract Factory e Singleton são padrões criacionais, usados para gerenciar a criação de objetos.
//O Repository Pattern é usado para encapsular o acesso aos dados e a lógica de persistência,
//separando-o da lógica de negócios.

//1. MVC (Model-View-Controller)
//Arquitetura: O padrão MVC é uma arquitetura usada para separar as preocupações de uma aplicação em
//três componentes principais:
//Model: Representa os dados e a lógica do negócio. É responsável por recuperar, manipular e armazenar
//os dados (geralmente de um banco de dados).
//View: Define a interface com o usuário e é responsável por apresentar os dados ao usuário, obtidos
//do Model. A View recebe os dados do Controller.
//Controller: Age como um intermediário entre a View e o Model. Ele processa a entrada do usuário,
//faz chamadas ao Model e retorna os dados atualizados à View.
//Exemplo: No ASP.NET Core, o Controller recebe uma requisição HTTP, manipula os dados (Model),
//e passa a resposta à View, que renderiza o HTML.

//2. IoC (Inversion of Control)
//Padrão de Projeto (Design Pattern): O IoC é um princípio que inverte o controle do fluxo de uma
//aplicação. No contexto de injeção de dependência, o IoC permite que um container ou framework
//forneça as dependências de uma classe em vez da própria classe instanciar suas dependências diretamente.
//Exemplo de uso: Em ASP.NET Core, o IoC Container é integrado, e você registra serviços e suas
//dependências na Startup.cs com o método ConfigureServices. Esses serviços são injetados em classes
//(como Controllers) automaticamente.

//3. MVVM (Model-View-ViewModel)
//Arquitetura: O padrão MVVM é uma evolução do MVC usada principalmente em aplicações que têm uma
//interface rica, como WPF ou aplicativos móveis.
//Model: Como no MVC, representa os dados e a lógica do negócio.
//View: Define a interface gráfica, como os controles visuais e elementos de UI.
//ViewModel: A ponte entre o Model e a View. Ele expõe os dados do Model à View e gerencia as
//interações com a UI. A diferença principal do Controller do MVC é que o ViewModel frequentemente
//interage com Bindings que permitem atualização automática da interface gráfica quando os dados mudam.
//Exemplo: No WPF (Windows Presentation Foundation), o ViewModel comunica-se diretamente com a View
//através de data-binding, tornando possível que a UI se atualize quando os dados mudam.

//4. Abstract Factory (Fábrica Abstrata)
//Padrão de Projeto (Design Pattern): O Abstract Factory é um padrão criacional que fornece uma
//interface para criar famílias de objetos relacionados ou dependentes sem especificar suas
//classes concretas. Isso permite que o código cliente utilize uma "fábrica" para instanciar
//objetos de diferentes famílias de produtos.
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
//Padrão de Projeto (Design Pattern): O Singleton é um padrão que garante que uma classe tenha
//apenas uma única instância e fornece um ponto global de acesso a essa instância.
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
// Este padrão é útil em situações em que é necessário ter exatamente uma instância de um objeto
// compartilhada em toda a aplicação (ex: gerenciamento de cache, configurações globais).

// 6. Repository Pattern (Padrão Repositório)
// Padrão de Projeto (Design Pattern): O Repository Pattern isola a lógica de acesso a dados da
// lógica de negócio. Ele atua como um intermediário entre a aplicação e a fonte de dados (como
// um banco de dados), fornecendo uma interface comum para acesso e manipulação dos dados.
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
// Este padrão permite que você tenha uma camada intermediária entre a lógica de negócios e a
// fonte de dados, facilitando a manutenção e teste da aplicação.