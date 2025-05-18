using Microsoft.EntityFrameworkCore;
using TestWeb.Models;

namespace TestWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Appetizers",
                    DisplayedOrder = 1
                },
                new Category
                {
                    Id = 2,
                    Name = "Main Course",
                    DisplayedOrder = 2
                },
                new Category
                {
                    Id = 3,
                    Name = "Desserts",
                    DisplayedOrder = 3
                }
                );
        }
    }
}
