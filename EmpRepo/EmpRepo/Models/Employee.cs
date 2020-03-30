using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmpRepo.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Please Enter EmployeeID")]
        public int? EmployeeID { get; set; }

        [Required(ErrorMessage = "Please Enter FirstName")]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Please Enter LastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Provide Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please Enter Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Enter City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please Enter State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please Enter Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please Enter Mobile Number")]
        public string Mobile { get; set; }
    }
}