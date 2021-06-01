using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClinicalManagementProject.Models;

namespace ClinicalManagementProject.Controllers
{
    public class ScheduleAppointmentsController : Controller
    {
        private readonly ClinicalContext _context;

        public ScheduleAppointmentsController(ClinicalContext context)
        {
            _context = context;
        }

        // GET: ScheduleAppointments
        public async Task<IActionResult> Index()
        {
            return View(await _context.AppointmentsTable.ToListAsync());
        }

        // GET: ScheduleAppointments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduleAppointment = await _context.AppointmentsTable
                .FirstOrDefaultAsync(m => m.AppointmentId == id);
            if (scheduleAppointment == null)
            {
                return NotFound();
            }

            return View(scheduleAppointment);
        }

        // GET: ScheduleAppointments/Create
        public IActionResult Create()
        {
            var patientsList = _context.PatientsTable.ToList();
            var doctorList = _context.DoctorsTable.ToList();
            ViewBag.patientsList = _context.PatientsTable.Select(x => x.PatientId).ToList();
            ViewBag.doctorList = _context.DoctorsTable.Select(x =>x.DoctorFirstName).ToList();
            return View();
        }

        // POST: ScheduleAppointments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AppointmentId,PatientId,Specialization,Name,VisitDate,StartTime")] ScheduleAppointment scheduleAppointment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(scheduleAppointment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(scheduleAppointment);
        }

        // GET: ScheduleAppointments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduleAppointment = await _context.AppointmentsTable.FindAsync(id);
            if (scheduleAppointment == null)
            {
                return NotFound();
            }
            return View(scheduleAppointment);
        }

        // POST: ScheduleAppointments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AppointmentId,PatientId,Specialization,Name,VisitDate,StartTime")] ScheduleAppointment scheduleAppointment)
        {
            if (id != scheduleAppointment.AppointmentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scheduleAppointment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScheduleAppointmentExists(scheduleAppointment.AppointmentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(scheduleAppointment);
        }

        // GET: ScheduleAppointments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduleAppointment = await _context.AppointmentsTable
                .FirstOrDefaultAsync(m => m.AppointmentId == id);
            if (scheduleAppointment == null)
            {
                return NotFound();
            }

            return View(scheduleAppointment);
        }

        // POST: ScheduleAppointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var scheduleAppointment = await _context.AppointmentsTable.FindAsync(id);
            _context.AppointmentsTable.Remove(scheduleAppointment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScheduleAppointmentExists(int id)
        {
            return _context.AppointmentsTable.Any(e => e.AppointmentId == id);
        }
    }
}
