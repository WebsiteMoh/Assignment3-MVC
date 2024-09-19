using Company.data.Entities;
using Company.Services.Departments_Services;
using Company.Services.Employees;
using Company.Services.Employees.DTO;
using Microsoft.AspNetCore.Mvc;
namespace Assignment3_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _context;
        private readonly ISdepartment _context2;


        public EmployeeController(IEmployeeService context, ISdepartment context2)
        {
            _context = context;
            _context2 = context2;
        }

        public IActionResult Index()
        {


            var employees = _context.get_all();
            return View(employees);
        }
        public IActionResult Create()
        {
            var departments = _context2.get_all();
            ViewBag.Department = departments;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmployeeDTO employee)
        {
            try
            {
                
                if (ModelState.IsValid)
                {
                    var departments = _context2.get_all();
                    ViewBag.Department = departments;
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
        public IActionResult Detials(EmployeeDTO employee)
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

        public IActionResult Update(EmployeeDTO employee,int ID)
        {
            var Emp = _context.select_by_ID(employee.Id);
            return Detials(Emp);
        }

        [HttpPost]
        public IActionResult Update(EmployeeDTO employee)
        {

            _context.update(employee);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Search(String CivilID) {
            if (String.IsNullOrEmpty(CivilID))
            {
                var emp = _context.get_all();
                return View(emp);
            }
            else
            {
                var emp = _context.Search(CivilID);
                return View(emp);
            }
        }
    }
}
