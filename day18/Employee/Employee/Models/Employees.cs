using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee.Models
{
    public class Employees
    {
        
        public int Id { get; set; }
        public string? Name { get; set; }
        public long phonenumber { get; set; }
        public string? Email { get; set; }
        public string? city { get; set; }
        public int age { get; set; }
    }
}
