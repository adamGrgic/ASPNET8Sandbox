using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sandbox.Data.MigrationData;

namespace Sandbox.Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Database project.");
            var services = new ServiceCollection();
            services.AddDbContext<TodoDbContext>(options =>
                options.UseSqlServer("Server=localhost;Database=TodoDemoDB;User Id=grgBabyDemo;Password=Hockey7232!;TrustServerCertificate=true;"));

            var serviceProvider = services.BuildServiceProvider();
            using (var context = serviceProvider.GetRequiredService<TodoDbContext>())
            {
                context.Database.Migrate();
            }


        }
    }
}
