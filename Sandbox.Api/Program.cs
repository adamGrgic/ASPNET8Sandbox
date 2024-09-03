using Sandbox.Data.DatabaseContext; // Ensure you have the correct namespace for TodoDbContext
using Sandbox.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Sandbox.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            System.Environment.SetEnvironmentVariable("DOTNET_SYSTEM_GLOBALIZATION_INVARIANT", "false");

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

            var app = builder.Build();

            // Add the IHttpContextFactory to the service collection
            builder.Services.AddHttpContextAccessor(); // This is needed for IHttpContextAccessor
            builder.Services.AddSingleton<IHttpContextFactory, DefaultHttpContextFactory>();

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
    }
}
