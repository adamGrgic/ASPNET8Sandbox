using Sandbox.Data.DatabaseContext; // Ensure you have the correct namespace for TodoDbContext
using Sandbox.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;
using Sandbox.Api.Controllers.Linq.EnumerableMethods;
using Sandbox.Api.Modules.Linq.EnumerableMethods.Select.Service;
using BenchmarkDotNet.Running;
using Microsoft.Extensions.Logging.Console;

namespace Sandbox.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Logging.ClearProviders();
            builder.Logging.AddConsole();

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Register the DbContext with the DI container
            builder.Services.AddDbContext<TodoDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Register the generic repository
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            // Register HttpClient
            builder.Services.AddHttpClient();

            builder.Services.AddMemoryCache();

            // Add the IHttpContextFactory to the service collection
            builder.Services.AddHttpContextAccessor(); // This is needed for IHttpContextAccessor
            builder.Services.AddSingleton<IHttpContextFactory, DefaultHttpContextFactory>();

            // note: can probably use a factory for creating these services since their uses are very specific / not needed across the entire application lifecycle
            builder.Services.AddScoped<ISelectService, SelectService>();

            var app = builder.Build();


            //IMemoryCache cache = app.Services.GetRequiredService<IMemoryCache>();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.Logger.LogInformation("Mapping routes");

            app.MapControllers();


            app.Logger.LogInformation("App is running");

            app.Run();
            app.MapGet("/Test", async (ILogger<Program> logger, HttpResponse response) =>
            {
                logger.LogInformation("Testing logging in Program.cs");
                await response.WriteAsync("Testing");
            });


            // todo: make a conditional run parameter for this

            // ...ideating. Might need some sort of wrapper function
            // maybe define certain scenarios
            // var thing = new SelectService();
            // var summary = BenchmarkRunner.Run<SelectService>();
        }

    }
}
