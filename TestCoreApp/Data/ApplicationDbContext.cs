using Microsoft.EntityFrameworkCore;
using TestCoreApp.Models;
using TestCoreApp.Areas.Employees.Models;

namespace TestCoreApp.Data
{

    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .Property(i => i.Price)
                .HasColumnType("float");
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Select Category" },
                new Category() { Id = 2, Name = "Computers" },
                new Category() { Id = 3, Name = "Mobiles" },
                new Category() { Id = 4, Name = "Electric Machines"}
                );
    ;
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public  DbSet<Employee> Employees { get; set; }

        public DbSet<TestCoreApp.Areas.Employees.Models.Employee> Employee { get; set; } = default!;
    }
}
