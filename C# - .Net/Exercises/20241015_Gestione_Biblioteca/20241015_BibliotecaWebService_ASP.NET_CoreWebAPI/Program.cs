using _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Repositories;
using BibliotecaWebService.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);     //Inicia a constru��o do aplicativo ASP.NET Core usando o m�todo CreateBuilder.

// Add services to the container.

builder.Services.AddDbContext<GestioneBibliotecaContext>(options =>
{                                                     //Adiciona o servi�o do Entity Framework para o contexto de banco de dados
                                                      //GestioneBibliotecaContext. O connectionString � lido da configura��o do
                                                      //aplicativo, do arquivo appsettings.json. Usa o SQL Server como o banco
                                                      //de dados com a configura��o passada.

    string connectionString = builder.Configuration.GetConnectionString("GestionaleBibliotecaDB");
    options.UseSqlServer(connectionString);

});
builder.Services.AddScoped<ClienteRepository>();      //Registra o ClienteRepository como um servi�o do tipo Scoped. Isso significa que
                                                      //ele ser� instanciado uma vez por requisi��o HTTP, ideal para servi�os que
                                                      //interagem com o banco de dados, j� que evita problemas de concorr�ncia.

builder.Services.AddControllers();                    //Adiciona o servi�o necess�rio para trabalhar com controllers, que s�o respons�veis
                                                      //por gerenciar as requisi��es HTTP e gerar as respostas apropriadas na API.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();                     //Adiciona o Swagger, uma ferramenta para gerar documenta��o autom�tica e fornecer uma
                                                      //interface visual para testar as APIs da aplica��o. O Swagger � muito �til em
                                                      //desenvolvimento e para garantir que os endpoints est�o documentados corretamente.

var app = builder.Build();                            //Constr�i o WebApplication com base nos servi�os e configura��es definidos no builder.

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI();                               //Se a aplica��o estiver rodando no ambiente de desenvolvimento (Development), o Swagger
                                                      //e sua interface visual s�o habilitados.
}

app.UseHttpsRedirection();                            //Redireciona todas as requisi��es HTTP para HTTPS.

app.UseAuthorization();                               //Configura o middleware para controle de autoriza��o.

app.MapControllers();                                 //Mapeia as rotas dos controllers da API.

app.Run();                                            //Inicia o aplicativo, ouvindo as requisi��es HTTP e respondendo de acordo com as rotas configuradas.
