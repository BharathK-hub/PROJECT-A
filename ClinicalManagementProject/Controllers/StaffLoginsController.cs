using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClinicalManagementProject.Models;
using ClinicalManagementProject.Services;
using Microsoft.Extensions.Logging;

namespace ClinicalManagementProject.Controllers
{
    public class StaffLoginsController : Controller
    {

        public readonly ILogger<StaffLoginsController> _logger;
        public readonly ILogin<StaffLogin> _repo;
        public StaffLoginsController(ILogger<StaffLoginsController> logger, ILogin<StaffLogin> repo)
        {
            _logger = logger;
            _repo = repo;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<StaffLogin> staffLogin = _repo.GetAll().ToList();
            return View(staffLogin);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StaffLogin staffLogin)
        {
            _repo.Add(staffLogin);
            return RedirectToAction("Index");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(StaffLogin staffLogin)
        {
            var obj = _repo.StaffLogin(staffLogin);
            try
            {
                if (obj != 0)
                {
                    return RedirectToAction("Success");
                }
            }
            catch (Exception e)

            {
                _logger.LogDebug(e.Message);

            }
            return RedirectToAction("Error");
        }
        public ActionResult Success()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
    }
}