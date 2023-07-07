using Microsoft.EntityFrameworkCore;
using BulkyWeb.Models;

namespace BulkyWeb.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }

        public DbSet<Category> categories { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "coffee", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Tea", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Crosscant", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Cold coffee", DisplayOrder = 4 });
        }
    }
}
