using CostManeger.Models;
using Microsoft.EntityFrameworkCore;

namespace CostManeger.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Users> Usuarios => Set<Users>();
        public DbSet<Profiles> Perfis => Set<Profiles>();
        public DbSet<Banks> Bancos => Set<Banks>();
        public DbSet<Installments> Parcelamento => Set<Installments>();
        public DbSet<Payments> Pagamentos => Set<Payments>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profiles>().HasData(
                new Profiles { Id = 1, Description = "General", IsActive = true, CreatedOn = DateTimeOffset.Now },
                new Profiles { Id = 2, Description = "Viewer", IsActive = true, CreatedOn = DateTimeOffset.Now },
                new Profiles { Id = 3, Description = "Administrator", IsActive = true, CreatedOn = DateTimeOffset.Now }
            );

            modelBuilder.Entity<Installments>().HasData(
                new Installments { Id = 1, Description = "1x - Preço à vista.", IsActive = true },
                new Installments { Id = 2, Description = "2x - ", IsActive = true },
                new Installments { Id = 3, Description = "3x - ", IsActive = true },
                new Installments { Id = 4, Description = "4x - ", IsActive = true },
                new Installments { Id = 5, Description = "5x - ", IsActive = true },
                new Installments { Id = 6, Description = "6x - ", IsActive = true },
                new Installments { Id = 7, Description = "7x - ", IsActive = true },
                new Installments { Id = 8, Description = "8x - ", IsActive = true },
                new Installments { Id = 9, Description = "9x - ", IsActive = true },
                new Installments { Id = 10, Description = "10x - ", IsActive = true },
                new Installments { Id = 11, Description = "11x - ", IsActive = true },
                new Installments { Id = 12, Description = "12x - ", IsActive = true }
            );
        }
    }
}
