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