using Company.data.Entites;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services.Employees.DTO
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public String Fname { get; set; }
        public String Lname { get; set; }

        public int age { get; set; }
        public String CivilID_Number { get; set; }
        public String Email { get; set; }
        public String Phone_Number { get; set; }

        public int? Dep_ID { get; set; }
        public IFormFile ImagePath { get; set; }
        public string ImgURL { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime DeletedAt { get; set; }


    }
}
