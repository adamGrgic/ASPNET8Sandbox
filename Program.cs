using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);


// Register HttpClient
builder.Services.AddHttpClient();

builder.Services.AddControllers();
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllers();
app.MapGet("/", () => "Hello World!");

app.Run();
