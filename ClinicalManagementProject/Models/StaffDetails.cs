using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalManagementProject.Models
{
    public class StaffDetails
    {
        [Key]
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Special characters cannot be used.")]
        public string UserName { get; set; }

        
        [Display(Name = "First Name")]
        public String StaffFirstName { get; set; }

        
        [Display(Name = "Last Name")]
        public String StaffLastName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
