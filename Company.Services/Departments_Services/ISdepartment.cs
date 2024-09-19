using Company.data.Entites;
using Company.data.Entities;
using Company.Services.Departments_Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services.Departments_Services
{
    public interface ISdepartment
    {
        public void add(DepartmentDTO Item);
        public void delete(DepartmentDTO Item);
        public IEnumerable<DepartmentDTO> get_all();
        public DepartmentDTO select_by_ID(int? ID);
        public void update(DepartmentDTO Item);

    }
}
