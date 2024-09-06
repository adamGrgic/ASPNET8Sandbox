using Sandbox.Data.DatabaseContext; // Ensure you have the correct namespace for TodoDbContext
using Sandbox.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace Sandbox.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

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

            var app = builder.Build();


            IMemoryCache cache = app.Services.GetRequiredService<IMemoryCache>();
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
        }

        void RunDatabaseProject()
        {
            // Example: Execute database project via command line
            var processInfo = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = "run --project $(SolutionDir)Sandbox.Database/Sandbox.Database.csproj", // Path to your database project
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = Process.Start(processInfo))
            {
                process.WaitForExit();
                if (process.ExitCode != 0)
                {
                    throw new Exception("Database project failed to start");
                }
            }
        }
    }
}
