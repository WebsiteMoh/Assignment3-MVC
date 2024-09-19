using Company.data.Entities;
using Company.Services.Employees.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services.Employees
{
    public interface IEmployeeService
    {
        public void add(EmployeeDTO Item);
        public void delete(EmployeeDTO Item);
        public IEnumerable<EmployeeDTO> get_all();
        public EmployeeDTO select_by_ID(int? ID);
        public void update(EmployeeDTO Item);
        public IEnumerable<EmployeeDTO> Search(string Civil_ID);

    }
}
