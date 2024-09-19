using AutoMapper;
using Company.data.Entities;
using Company.Repositry.Interfaces;
using Company.Repositry.Repositiers;
using Company.Services.Departments_Services.DTO;
using Company.Services.Employees.DTO;
using Company.Services.Helper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NetTopologySuite.Index.HPRtree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services.Employees
{
    public class EmpService : IEmployeeService
    {
        private readonly EmployeeInterface _context;
        private readonly IMapper _Mapper;


        public EmpService(EmployeeInterface output,IMapper mapper)
        {
            _context = output;
            _Mapper = mapper;
        }
        public void add(EmployeeDTO Item)
        {
            Item.ImgURL = DocumentSettings.UploadFile(Item.ImagePath, "Images");
            var Emp = _Mapper.Map<Employee>(Item);
            _context.add(Emp);
        }

        public void delete(EmployeeDTO Item)
        {
            var Emp = _Mapper.Map<Employee>(Item);
            _context.delete(Emp);

        }

        public IEnumerable<EmployeeDTO> get_all()
        {
            var All_Emp = _context.get_all();
           var Emp = _Mapper.Map<IEnumerable<EmployeeDTO>>(All_Emp);
            return Emp;
        }

        public EmployeeDTO select_by_ID(int? ID)
        {
            var All_Emp = _context.select_by_ID(ID);
            var Emp = _Mapper.Map<EmployeeDTO>(All_Emp);



            return Emp;
        }

        public void update(EmployeeDTO Item)
        {
            var Emp = select_by_ID(Item.Id);

          var Emp2= _Mapper.Map<Employee>(Emp);



            _context.update(Emp2);
        }
        public IEnumerable<EmployeeDTO> Search(string Input)
        {
            var All_Emp = _context.Search(Input);
            var Emp = _Mapper.Map<IEnumerable<EmployeeDTO>>(All_Emp);


            return Emp;
        }
    }
}
