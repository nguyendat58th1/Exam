using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exam.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Exam.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDBContext _context;
        public EmployeeController(EmployeeDBContext context)
        {
            _context = context;
        }

        public IActionResult ListEmployees()
        {
            var listEmployees = _context.Employees.AsQueryable();
            return View(listEmployees);
        }

        public IActionResult Create()
        {
            var getDepartment = _context.Departments.AsQueryable();
            SelectList slDepartments = new SelectList(getDepartment, "Id", "DepartmentName");
            ViewBag.DepartmentId = slDepartments;

            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee em)
        {
            var getDepartment = _context.Departments.AsQueryable();
            SelectList slDepartments = new SelectList(getDepartment, "Id", "DepartmentName");
            ViewBag.DepartmentId = slDepartments;
            if (ModelState.IsValid)
            {


                try
                {
                    await _context.Employees.AddAsync(em);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("ListEmployees", "Employee");
                }
                catch
                {

                    ModelState.AddModelError("", "Create Error");
                }

            }
            return View("Create");
        }
    }
}