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
    public class StaffDetailsController : Controller
    {
        private readonly ClinicalContext _context;

        public StaffDetailsController(ClinicalContext context)
        {
            _context = context;
        }

        // GET: StaffDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.StaffsTable.ToListAsync());
        }

        // GET: StaffDetails/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffDetails = await _context.StaffsTable
                .FirstOrDefaultAsync(m => m.UserName == id);
            if (staffDetails == null)
            {
                return NotFound();
            }

            return View(staffDetails);
        }

        // GET: StaffDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StaffDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserName,StaffFirstName,StaffLastName,Password")] StaffDetails staffDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(staffDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(staffDetails);
        }

        // GET: StaffDetails/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffDetails = await _context.StaffsTable.FindAsync(id);
            if (staffDetails == null)
            {
                return NotFound();
            }
            return View(staffDetails);
        }

        // POST: StaffDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UserName,StaffFirstName,StaffLastName,Password")] StaffDetails staffDetails)
        {
            if (id != staffDetails.UserName)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(staffDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StaffDetailsExists(staffDetails.UserName))
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
            return View(staffDetails);
        }

        // GET: StaffDetails/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffDetails = await _context.StaffsTable
                .FirstOrDefaultAsync(m => m.UserName == id);
            if (staffDetails == null)
            {
                return NotFound();
            }

            return View(staffDetails);
        }

        // POST: StaffDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var staffDetails = await _context.StaffsTable.FindAsync(id);
            _context.StaffsTable.Remove(staffDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StaffDetailsExists(string id)
        {
            return _context.StaffsTable.Any(e => e.UserName == id);
        }
    }
}
