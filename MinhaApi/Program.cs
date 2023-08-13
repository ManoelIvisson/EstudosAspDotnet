var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Olá mundo!");
app.MapGet("/rotas{nome}", (string nome) => {
        return Results.Ok($"De volta a rota {nome}:)");
    });

app.MapPost("/", (Usuario usuario) => {
    return Results.Ok(usuario);
});

app.Run();

public class Usuario {
    public int Id { get; set; }
    public string? Nome { get; set; }
}