using _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Repositories;
using BibliotecaWebService.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);     //Inicia a construção do aplicativo ASP.NET Core usando o método CreateBuilder.

// Add services to the container.

builder.Services.AddDbContext<GestioneBibliotecaContext>(options =>
{                                                     //Adiciona o serviço do Entity Framework para o contexto de banco de dados
                                                      //GestioneBibliotecaContext. O connectionString é lido da configuração do
                                                      //aplicativo, do arquivo appsettings.json. Usa o SQL Server como o banco
                                                      //de dados com a configuração passada.

    string connectionString = builder.Configuration.GetConnectionString("GestionaleBibliotecaDB");
    options.UseSqlServer(connectionString);

});
builder.Services.AddScoped<ClienteRepository>();      //Registra o ClienteRepository como um serviço do tipo Scoped. Isso significa que
                                                      //ele será instanciado uma vez por requisição HTTP, ideal para serviços que
                                                      //interagem com o banco de dados, já que evita problemas de concorrência.

builder.Services.AddControllers();                    //Adiciona o serviço necessário para trabalhar com controllers, que são responsáveis
                                                      //por gerenciar as requisições HTTP e gerar as respostas apropriadas na API.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();                     //Adiciona o Swagger, uma ferramenta para gerar documentação automática e fornecer uma
                                                      //interface visual para testar as APIs da aplicação. O Swagger é muito útil em
                                                      //desenvolvimento e para garantir que os endpoints estão documentados corretamente.

var app = builder.Build();                            //Constrói o WebApplication com base nos serviços e configurações definidos no builder.

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI();                               //Se a aplicação estiver rodando no ambiente de desenvolvimento (Development), o Swagger
                                                      //e sua interface visual são habilitados.
}

app.UseHttpsRedirection();                            //Redireciona todas as requisições HTTP para HTTPS.

app.UseAuthorization();                               //Configura o middleware para controle de autorização.

app.MapControllers();                                 //Mapeia as rotas dos controllers da API.

app.Run();                                            //Inicia o aplicativo, ouvindo as requisições HTTP e respondendo de acordo com as rotas configuradas.
