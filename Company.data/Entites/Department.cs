using Company.data.Model;
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

        
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Employee> Employees { get; set; }= new List<Employee>();
    }
}
