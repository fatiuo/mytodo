
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
var app = builder.Build();

app.MapGet("/Hello", () => "Hello World!");

app.Run();
