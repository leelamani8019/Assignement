using System.ComponentModel.DataAnnotations;

namespace EmployeeApiConsume.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public long phonenumber { get; set; }
        public string? Email { get; set; }
        public string? city { get; set; }
        public int age { get; set; }
    }
}
