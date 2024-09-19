using Company.data.Entities;
using Company.Repositry.Interfaces;
using Company.Repositry.Repositiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services
{
    public class EmpService : IEmployeeService
    {
        private readonly EmployeeInterface _context;
        public EmpService(EmployeeInterface output) {
        _context= output;
        }
        public void add(Employee Item)
        {
            Employee Emp = new Employee
            {
                Fname=Item.Fname,
                Lname=Item.Lname,
                CivilID_Number=Item.CivilID_Number,
                Phone_Number=Item.Phone_Number,
                Email=Item.Email,
                age=Item.age,
                createdAt=DateTime.Now,
                DeletedAt=DateTime.Now,

            };
            _context.add( Emp );
        }

        public void delete(Employee Item)
        {
            _context.delete(Item);
            
        }

        public IEnumerable<Employee> get_all()
        {
            var All_Emp = _context.get_all();
            return All_Emp;
        }

        public Employee select_by_ID(int? ID)
        {
            return _context.select_by_ID(ID);
        }

        public void update(Employee Item)
        {
            var Emp = select_by_ID(Item.Id);

            Console.WriteLine(Emp.Fname);
                Emp.Fname = Item.Fname;
                Emp.Lname = Item.Lname;
                Emp.CivilID_Number = Item.CivilID_Number;
                Emp.Phone_Number = Item.Phone_Number;
                Emp.Email = Item.Email;
                Emp.age = Item.age;
                

         
            _context.update(Emp);
        }
    }
}
