using AttendanceManagement.Data;
using AttendanceManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceManagement.Controllers
{
    public class AttendanceController : Controller 
    {
        AttendanceModel _context;
        public AttendanceController(AttendanceModel context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AttendanceIndex()
        {
            var emp= new Employee();
            List <Employee> EmployeeList= _context.Employee.ToList();

            return View(EmployeeList);
        }
        public IActionResult ReportIndex()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddEmployeeIndex()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployeeIndex(Employee emp)
        {
            if (ModelState.IsValid) 
            {
            _context.Employee.Add(emp);
            _context.SaveChanges();
                return RedirectToAction("AttendanceIndex");            }
            return View();
        }

    }
}
