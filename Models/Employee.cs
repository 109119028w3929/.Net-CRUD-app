using System.ComponentModel.DataAnnotations;

namespace EmployeeCrudApp.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        public string Department { get; set; }

        [Range(1, 1000000)]
        public decimal Salary { get; set; }
    }
}