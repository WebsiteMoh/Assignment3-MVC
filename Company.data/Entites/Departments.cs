using Company.data.Entities;
using Company.data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.data.Entites
{
    public class Departments :BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
