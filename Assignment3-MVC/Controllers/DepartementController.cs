using Company.Repositry.Interfaces;
using Company.Repositry.Repositiers;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3_MVC.Controllers
{
    public class DepartementController : Controller
    {
        private readonly DepartmentInterface _context;

        public DepartementController(DepartmentInterface context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            var department = _context.get_all();
            return View(department);
        }
    }
}
