using Microsoft.EntityFrameworkCore;
using MinimalApi.Dtos;
using MinimalApi.infraestrutura.Db;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbContexto>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("mysql"),
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql"))
    );
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (LoginDTO loginDTO) =>
{
    if (loginDTO.Senha == "123456")
        return Results.Ok("Logado com sucesso!");
    else
        return Results.Unauthorized();
});


app.Run();


