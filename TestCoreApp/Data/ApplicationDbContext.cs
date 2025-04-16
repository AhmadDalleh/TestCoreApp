using Microsoft.EntityFrameworkCore;
using TestCoreApp.Models;
using TestCoreApp.Areas.Employees.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace TestCoreApp.Data
{


    public class ApplicationDbContext: IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
            
        }
        public DbSet<Item> Items { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                  new Category() { Id = 1, Name = "Select Category" },
                  new Category() { Id = 2, Name = "Computers" },
                  new Category() { Id = 3, Name = "Mobiles" },
                  new Category() { Id = 4, Name = "Electric machines" }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
