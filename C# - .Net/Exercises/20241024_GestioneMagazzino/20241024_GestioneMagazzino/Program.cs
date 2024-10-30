



using _20241024_GestioneMagazzino.Models;
using _20241024_GestioneMagazzino.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<GestioneMagazzinoContext>(options =>
{

    string connectionstring = builder.Configuration.GetConnectionString("GestionaleBibliotecaDB");
    options.UseSqlServer(connectionstring);

});

builder.Services.AddScoped<ClienteRepository>();
builder.Services.AddScoped<FornitoreRepository>();
builder.Services.AddScoped<ProdottoRepository>();
builder.Services.AddScoped<OrdineClienteTestaRepository>();
builder.Services.AddScoped<OrdineClienteDettaglioRepository>();
builder.Services.AddScoped<OrdineFornitoreTestaRepository>();
builder.Services.AddScoped<OrdineFornitoreTestaRepository>();
builder.Services.AddScoped<MovimentoMagazzinoRepository>();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
