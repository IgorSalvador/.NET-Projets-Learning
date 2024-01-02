using CostManeger.Models;
using Microsoft.EntityFrameworkCore;

namespace CostManeger.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios => Set<Usuario>();
        public DbSet<Perfis> Perfis => Set<Perfis>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Perfis>().HasData(
                new Perfis { Id = 1, Description = "General", IsActive = true, CreatedOn = DateTimeOffset.Now },
                new Perfis { Id = 2, Description = "Viewer", IsActive = true, CreatedOn = DateTimeOffset.Now },
                new Perfis { Id = 3, Description = "Administrator", IsActive = true, CreatedOn = DateTimeOffset.Now }
            );;
        }
    }
}
