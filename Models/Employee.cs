using System.ComponentModel.DataAnnotations;

namespace Exam.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name mustn't empty")]
        public string Name { get; set; }
        [Display(Name = "Department")]
        [Required(ErrorMessage = "Department mustn't empty")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        [Required(ErrorMessage = "Salary mustn't empty")]
        public double Salary { get; set; }
    }
}