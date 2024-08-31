using Company.data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repositry.Interfaces
{
    public interface DepartmentInterface 
    {
        public void add(Department Item);
        public void delete(Department Item);
        public IEnumerable<Department> get_all();

        public Department select_by_ID(int ID);

        public void update(Department Item);

    }
}
