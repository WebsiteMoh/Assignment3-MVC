using Company.data.Context;
using Company.data.Entities;
using Company.Repositry.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repositry.Repositiers
{
    public class DepartmentRep :  DepartmentInterface
    {
        private readonly CompanyDBcontext _context;
        public DepartmentRep(CompanyDBcontext context)
        {
            _context = context;
        }

        public void add(Department Item)
        {
            _context.Add(Item);
        }

        public void delete(Department Item)
        {
            _context.Remove(Item);
        }

        public IEnumerable<Department> get_all()
        => _context.Departments.ToList();
        

        public Department select_by_ID(int ID)
        {
            return _context.Departments.Find(ID);
        }

        public void update(Department Item)
        {
            _context.Update(Item);
        }
    }
      
}
