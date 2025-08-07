using MinimalApi.Dtos;
var builder = WebApplication.CreateBuilder(args);
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


