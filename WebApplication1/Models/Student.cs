using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Student name cannot be blank")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Student name must be 3-50 characters")]
        [RegularExpression(@"^[a-zA-Z\s'-]*$", ErrorMessage = "Student name can only contain letters, spaces, hyphens and apostrophes")]
        [Display(Name = "Student Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address cannot be blank")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Address must be 5-200 characters")]
        public string Address { get; set; }
        public int CampusID { get; set; }
        public virtual UniversityCampus Campus { get; set; }
    }
}