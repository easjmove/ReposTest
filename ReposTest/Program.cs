using BooksAPI.Managers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSingleton<BooksRepository>(new BooksRepository());

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();
