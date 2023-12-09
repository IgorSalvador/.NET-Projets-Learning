using Microsoft.EntityFrameworkCore;
using TWTodoList.Data.EntityConfigs;
using TWTodoList.Models;

namespace TWTodoList.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Todo> Todos {  get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new TodoEntityConfig());
        }
    }
}
