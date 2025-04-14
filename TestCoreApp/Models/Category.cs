using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace TestCoreApp.Models
{
    public class Category
    {
        public Category()
        {
            Items = new HashSet<Item>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

        public ICollection<Item>? Items { get; set; }
    }
}
