using System.ComponentModel.DataAnnotations;

namespace TestCoreApp.Areas.Employees.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string? Email { get; set; }

        [MaxLength(200)]
        public string? Phone { get; set; }

        public int Age { get; set; }
        
        public decimal? Salary { get; set; }

    }
}
