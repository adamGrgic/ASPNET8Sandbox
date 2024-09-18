using Sandbox.Data.DatabaseContext; // Ensure you have the correct namespace for TodoDbContext
using Sandbox.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;
using Sandbox.Api.Controllers.Linq.EnumerableMethods;
using Sandbox.Api.Modules.Linq.EnumerableMethods.Select.Service;
using BenchmarkDotNet.Running;
using Microsoft.Extensions.Logging.Console;
using Sandbox.Api.Modules.DependencyInjection;
using Sandbox.Api.Modules.DesignPatterns.FactoryPattern.AdvancedShapeFactoryComponents;
using Sandbox.Api.Modules.DataStructuresAndAlgorithms.BinarySearchTree;

namespace Sandbox.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Logging.ClearProviders();
            builder.Logging.AddConsole();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowReactApp",
                    builder =>
                    {
                        builder.WithOrigins("https://localhost:5173")
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    });
            });


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
            builder.Services.AddScoped<IBinarySearchTree, BinarySearchTree>();

            // The purpose of a keyed singleton is to allow multiple singleton instances of the
            // same class, each identified by a unique key, while still adhering to the singleton
            // lifecycle for each individual instance.

            // See Modules.DependencyInjection
            builder.Services.AddKeyedSingleton<ICache, BigCache>("big");
            builder.Services.AddKeyedSingleton<ICache, SmallCache>("small");
            //


            var app = builder.Build();

            app.UseCors("AllowReactApp");

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
