using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalManagementProject.Models
{
    public class DoctorDetails
    {
        [Key]
        [Display(Name = "Doctor ID")]
        public int DoctorId { get; set; }

        [Required(ErrorMessage = "First Name is required!")]
        [Display(Name = "First Name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Special characters cannot be used.")]
        public string DoctorFirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required!")]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Special characters cannot be used.")]
        public string DoctorLastName { get; set; }

        [Required(ErrorMessage = "Sex is required!")]
        public string Sex { get; set; }

        [Required(ErrorMessage = "Specialization is required!")]
        public string Specialization { get; set; }

        //[Required]
        [Display(Name = "Visiting Hours:Start Time")]
        [DataType(DataType.Time), DisplayFormat(DataFormatString = "{0:HH:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime StartTime { get; set; }

        //[Required]
        [Display(Name = "Visiting Hours:End Time")]
        [DataType(DataType.Time), DisplayFormat(DataFormatString = "{0:HH:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime EndTime { get; set; }
    }
}
