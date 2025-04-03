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
            modelBuilder.Entity<Item>()
                .Property(i => i.Price)
                .HasColumnType("float");
        }
        public DbSet<Item> Items { get; set; }
    }
}
