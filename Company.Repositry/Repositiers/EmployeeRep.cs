using Company.data.Context;
using Company.data.Entities;
using Company.Repositry.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repositry.Repositiers
{
    public class EmployeeRep : EmployeeInterface
    {
        private readonly CompanyDBcontext _context;
        public EmployeeRep(CompanyDBcontext context)
        {
            _context = context;
        }
        public void add(Employee Item)
        {
            _context.Add(Item);
            _context.SaveChanges();

        }

        public void delete(Employee Item)
        {
            _context.Remove(Item);
            _context.SaveChanges();

        }

        public IEnumerable<Employee> get_all()
        {
            return _context.Employees.ToList();
        }

        public Employee select_by_ID(int ? ID)
        {
            return _context.Employees.Find(ID);
        }

        public void update(Employee Item)
        {
            _context.Update(Item);
            _context.SaveChanges();
        }
        public IEnumerable<Employee> Search(String Civil_ID)
        {
        var employee= _context.Employees.Where(emp=>emp.CivilID_Number.Trim().Contains(Civil_ID.Trim())).ToList();
            return employee;
        }
    }
}
