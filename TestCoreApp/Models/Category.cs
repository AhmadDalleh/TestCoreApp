using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.Mime.MediaTypeNames;

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

        [NotMapped]
        public IFormFile? ClientFile { get; set; }

        public byte[]? DbImage { get; set; }

        [NotMapped]
        public string? imageSrc
        {
            get
            {
                if (DbImage != null)
                {
                    string base64String = Convert.ToBase64String(DbImage, 0, DbImage.Length);
                    return "data:image/jpg;base64," + base64String;
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }
}
