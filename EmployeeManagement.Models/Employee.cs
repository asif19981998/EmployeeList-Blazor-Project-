using EmployeeManagement.Models.CustomValidators;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="Employee Name must be Provided")]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        //[EmailDomainValidator(AllowedDomain ="rakib@gmail.com")]
        public string Email { get; set; }
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }
       
        public string PhotoPath { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
