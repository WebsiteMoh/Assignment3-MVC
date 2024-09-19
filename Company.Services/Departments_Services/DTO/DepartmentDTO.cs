using Company.data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services.Departments_Services.DTO
{
    public class DepartmentDTO
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime DeletedAt { get; set; }

    }
}
