using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalManagementProject.Models
{
    public class PatientDetails
    {
        [Key]
        [Display(Name = "Patient ID")]
        public int PatientId { get; set; }

        [Required(ErrorMessage = "First Name is required!")]
        [Display(Name = "First Name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Special characters cannot be used.")]
        public string PatientFirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required!")]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Special characters cannot be used.")]
        public string PatientLastName { get; set; }

        [Required(ErrorMessage = "Sex is required!")]
        public string Sex { get; set; }

        [Required(ErrorMessage = "Age is required!")]
        [Range(0, 120)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Date Of Birth is required!")]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
    }
}
