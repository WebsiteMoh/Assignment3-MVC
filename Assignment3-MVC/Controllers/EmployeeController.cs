using Company.data.Entities;
using Company.Services;
using Microsoft.AspNetCore.Mvc;
namespace Assignment3_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _context;

        public EmployeeController(IEmployeeService context)
        {
            _context = context;

        }

        public IActionResult Index()
        {


            var employees = _context.get_all();
            return View(employees);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            try
            {
                
                if (ModelState.IsValid)
                {   

                    _context.add(employee);
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("EmployeeError","Vaildation Error");
                return View(employee);
            }catch (Exception ex)
            {
                ModelState.AddModelError("EmployeeError",ex.Message);
                return View(employee);
            }
        }
        [HttpGet]
        public IActionResult Detials(Employee employee)
        {
            if(employee == null)
            {
                return View();
            }
            else
            {
                var Emp = _context.select_by_ID(employee.Id);
                return View(Emp);
            }
        }
        public IActionResult Delete(int? ID)
        {
            var emp = _context.select_by_ID(ID);


            _context.delete(emp);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(Employee employee,int ID)
        {
            var Emp = _context.select_by_ID(employee.Id);
            return Detials(Emp);
        }

        [HttpPost]
        public IActionResult Update(Employee employee)
        {

            _context.update(employee);
            return RedirectToAction(nameof(Index));
        }
    }
}
