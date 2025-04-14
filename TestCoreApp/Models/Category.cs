using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace TestCoreApp.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string? Name { get; set; }

        public ICollection<Item>? Items { get; set; }
    }
}
