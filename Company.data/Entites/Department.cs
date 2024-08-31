﻿using Company.data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.data.Entities
{
    public class Department:BaseEntity
    {

        [Required]
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
