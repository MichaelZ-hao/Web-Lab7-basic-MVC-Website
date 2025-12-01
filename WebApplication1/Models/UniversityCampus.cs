using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UniversityCampus
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Campus name cannot be blank")] // 必填
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Campus name must be 3-50 characters")] 
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Campus name must start with a capital letter and contain only letters/spaces")]
        [Display(Name = "Campus Name")]
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }

    }
}