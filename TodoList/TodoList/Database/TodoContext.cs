using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Database
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
            
        }

        public DbSet<Todo> Todos { get; set; }
    }
}
