using Company.data.Entites;
using Company.data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repositry.Interfaces
{
    public interface IdepartmentRep
    {
        public void add(Departments Item);
        public void delete(Departments Item);
        public IEnumerable<Departments> get_all();
        public Departments select_by_ID(int? ID);
        public void update(Departments Item);
    }
}
