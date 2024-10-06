using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models;
using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Repositories;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        builder.Services.AddDbContext<ItsCorsiEsamiContext>(
            dbContextOptionsBuilder =>
            {
                string connectionString = builder.Configuration.GetConnectionString("ITSEsempidb");
                dbContextOptionsBuilder.UseSqlServer(connectionString);
            });

        builder.Services.AddScoped<StudentiRepository>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
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