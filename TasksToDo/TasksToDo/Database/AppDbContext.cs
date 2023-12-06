using Microsoft.EntityFrameworkCore;
using TasksToDo.Models;

namespace TasksToDo.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }

    }
}
