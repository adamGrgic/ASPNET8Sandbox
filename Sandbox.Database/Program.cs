using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sandbox.Data.DatabaseContext;
using Sandbox.Data.Repositories;

namespace Sandbox.Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Database project.");

            var services = new ServiceCollection();

            // Register the DbContext with the DI container
            services.AddDbContext<TodoDbContext>(options =>
                options.UseSqlServer("Server=localhost;Database=TodoDemoDB;User Id=grgBabyDemo;Password=Hockey7232!;TrustServerCertificate=true;"));

            // Register the generic repository
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            using (var serviceProvider = services.BuildServiceProvider())
            {
                // Apply pending migrations
                using (var context = serviceProvider.GetRequiredService<TodoDbContext>())
                {
                    context.Database.Migrate();
                }
            }

            //Environment.SetEnvironmentVariable("DOTNET_SYSTEM_GLOBALIZATION_INVARIANT", "false");

        }
    }
}