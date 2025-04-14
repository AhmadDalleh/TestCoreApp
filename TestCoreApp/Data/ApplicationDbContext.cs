using Microsoft.EntityFrameworkCore;
using TestCoreApp.Models;

namespace TestCoreApp.Data
{

    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { CategoryId = 1, Name = "Select Category" },
                new Category() { CategoryId = 2, Name = "Computers" },
                new Category() { CategoryId = 3, Name = "Mobiles" },
                new Category() { CategoryId = 4, Name = "Electric Machines"}
                );
    ;
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Employees> Employees { get; set; }
    }
}
