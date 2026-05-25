using EmployeeCrudApp.Data;
using EmployeeCrudApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrudApp.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // READ
        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();

            return View(employees);
        }

        // CREATE GET
        public IActionResult Create()
        {
            return View();
        }

        // CREATE POST
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(employee);

                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // EDIT GET
        public IActionResult Edit(int id)
        {
            var employee = _context.Employees.Find(id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // EDIT POST
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Update(employee);

                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // DELETE GET
        public IActionResult Delete(int id)
        {
            var employee = _context.Employees.Find(id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // DELETE POST
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var employee = _context.Employees.Find(id);

            if (employee != null)
            {
                _context.Employees.Remove(employee);

                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}