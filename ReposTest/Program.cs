using BooksAPI.Managers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddSingleton<BooksRepository>(new BooksRepository());

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();
