using Company.Repositry.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace Assignment3_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeInterface _context;

        public EmployeeController(EmployeeInterface context)
        {
            _context = context;

        }

        public IActionResult Index()
        {

            var employees = _context.get_all();
            return View(employees);
        }
    }
}
