using ClinicalManagementProject.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalManagementProject.Services
{
    public class Manager : ILogin<StaffLogin>, IRepo<DoctorDetails>, IRepo<PatientDetails>, IRepo<ScheduleAppointment>
    {
        private ClinicalContext _context;
        private ILogger<Manager> _logger;

        public Manager()
        {

        }
        public Manager(ClinicalContext context, ILogger<Manager> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Add(DoctorDetails t)
        {
            _context.DoctorsTable.Add(t);
            _context.SaveChanges();
        }

        public void Add(PatientDetails t)
        {
            _context.PatientsTable.Add(t);
            _context.SaveChanges();
        }

        public void Add(ScheduleAppointment t)
        {
            throw new NotImplementedException();
        }

        public void Add(StaffLogin t)
        {
            throw new NotImplementedException();
        }

        public DoctorDetails Get(int id)
        {
            try
            {
                DoctorDetails doctor = _context.DoctorsTable.FirstOrDefault(a => a.DoctorId == id);
                return doctor;
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }

        public IEnumerable<StaffLogin> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool SignIn(StaffLogin t)
        {
            try
            {
                StaffLogin login = _context.LoginTable.SingleOrDefault(u => u.UserName == t.UserName);
                if (login.Password == t.Password)
                    return true;
            }
            catch (Exception)
            {

                return false;
            }
            return false;
        }

        public int StaffLogin(StaffLogin t)
        {
            throw new NotImplementedException();
        }

        PatientDetails IRepo<PatientDetails>.Get(int id)
        {
            try
            {
                PatientDetails patient = _context.PatientsTable.FirstOrDefault(a => a.PatientId == id);
                return patient;
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }

        ScheduleAppointment IRepo<ScheduleAppointment>.Get(int id)
        {
            try
            {
                ScheduleAppointment scheduleAppointment = _context.AppointmentsTable.FirstOrDefault(a => a.AppointmentId == id);
                return scheduleAppointment;
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }
    }
}