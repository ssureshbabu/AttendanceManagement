using Microsoft.AspNetCore.Mvc;

namespace AttendanceManagement.Controllers
{
    public class AttendanceController : Controller 
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AttendanceIndex()
        {
            return View();
        }
        public IActionResult ReportIndex()
        {
            return View();
        }
        public IActionResult AddEmployeeIndex()
        {
            return View();
        }

    }
}
