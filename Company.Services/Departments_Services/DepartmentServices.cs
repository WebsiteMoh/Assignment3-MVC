using AutoMapper;
using Company.data.Entites;
using Company.Repositry.Interfaces;
using Company.Services.Departments_Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services.Departments_Services
{
    public class DepartmentServices : ISdepartment
    {

        private readonly IdepartmentRep _context;
        private readonly IMapper _Mapper;

        public DepartmentServices(IdepartmentRep output , IMapper Mapper)
        {
            _context = output;
            _Mapper= Mapper;
        }
        public void add(DepartmentDTO Item)
        {
            throw new NotImplementedException();
        }

        public void delete(DepartmentDTO Item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DepartmentDTO> get_all()
        {
           var DEP = _context.get_all();
           IEnumerable<DepartmentDTO> Dep = _Mapper.Map<IEnumerable<DepartmentDTO>>(DEP);
            return Dep;
        }

        public DepartmentDTO select_by_ID(int? ID)
        {
            throw new NotImplementedException();
        }

        public void update(DepartmentDTO Item)
        {
            throw new NotImplementedException();
        }
    }
}
