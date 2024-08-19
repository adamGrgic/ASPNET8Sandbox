using Sandbox.Data.Models.Todo;
using Microsoft.EntityFrameworkCore;

namespace Sandbox.Data.DatabaseContext
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options)
            : base(options)
        {
        }
        public DbSet<TodoItem> Todos { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
