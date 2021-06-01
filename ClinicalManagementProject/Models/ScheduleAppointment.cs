using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalManagementProject.Models
{
    public class ScheduleAppointment
    {

        [Key]
        [Display(Name = "Appointment ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AppointmentId { get; set; }

        [Required(ErrorMessage = "Patient Id is required!")]
        [Display(Name = "Patient Id")]
        public int PatientId { get; set; }

        [Required(ErrorMessage = "Specialization is required!")]
        public string Specialization { get; set; }

        [Required(ErrorMessage = "Doctor must be selected!")]
        [Display(Name = "Doctors Available")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime VisitDate { get; set; }

        [Display(Name = "Appointment Time")]
        [DataType(DataType.Time), DisplayFormat(DataFormatString = "{0:HH:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime StartTime { get; set; }
    }
}
