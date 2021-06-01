using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalManagementProject.Models
{
    public class ClinicalContext:DbContext
    {
        public ClinicalContext(DbContextOptions<ClinicalContext> options) : base(options)
        {

        }

        public DbSet<StaffDetails> StaffsTable { get; set; }
        public DbSet<DoctorDetails> DoctorsTable { get; set; }
        public DbSet<PatientDetails> PatientsTable { get; set; }
        public DbSet<ScheduleAppointment> AppointmentsTable { get; set; }
        public DbSet<StaffLogin> LoginTable { get; set; }
        
    }
}
