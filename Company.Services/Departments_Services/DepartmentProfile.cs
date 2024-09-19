using AutoMapper;
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
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile() {
             CreateMap<Departments, DepartmentDTO>().ReverseMap();

        }
    }
}
