using Company.data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services
{
    public interface IEmployeeService
    {
        public void add(Employee Item);
        public void delete(Employee Item);
        public IEnumerable<Employee> get_all();
        public Employee select_by_ID(int? ID);
        public void update(Employee Item);
    }
}
