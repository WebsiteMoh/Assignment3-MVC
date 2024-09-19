using AutoMapper;
using Company.data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services.Employees.DTO
{
    public class EmployeeProfile :Profile
    {
        public EmployeeProfile() {
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
        }
    }
}
