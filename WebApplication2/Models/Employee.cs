//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int EmpId { get; set; }
        //[Required]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "Please Enter Department Name")]
        public string EmpDepartment { get; set; }

        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   //ErrorMessage = "Please Enter valid Phone Number")]
        //[Required(ErrorMessage = "Please Enter Phone Number")]
        public string EmpPhone { get; set; }

        //[Required(ErrorMessage = "Please Enter Employee Address")]

        public string EmpAddress { get; set; }

        //[EmailAddress(ErrorMessage = "Please Enter Valid Email Address")]
        //[Required(ErrorMessage = "Please Enter Email Address")]
        public string EmpEmailId { get; set; }
    }
}
