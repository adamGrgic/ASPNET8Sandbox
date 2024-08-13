using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Sandbox.Data.MigrationData;

namespace Sandbox.Data
{
    public class TodoDbContextFactory
    {
        public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<TodoDbContext>
        {
            public TodoDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<TodoDbContext>();
                optionsBuilder.UseSqlServer("Server=localhost;Database=TodoDemoDB;User Id=grgBabyDemo;Password=Hockey7232!;TrustServerCertificate=true;");

                return new TodoDbContext(optionsBuilder.Options);
            }
        }
    }
}
