using Company.data.Context;
using Company.data.Entites;
using Company.Repositry.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repositry.Repositiers
{
    public class DepRep : IdepartmentRep
    {
        private readonly CompanyDBcontext _context;
        public DepRep(CompanyDBcontext context)
        {
            _context = context;
        }
        public void add(Departments Item)
        {
            throw new NotImplementedException();
        }

        public void delete(Departments Item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Departments> get_all()
        {
            return _context.Department.ToList();
        }

        public Departments select_by_ID(int? ID)
        {
            throw new NotImplementedException();
        }

        public void update(Departments Item)
        {
            throw new NotImplementedException();
        }
    }
}
