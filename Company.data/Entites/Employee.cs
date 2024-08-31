using Company.data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.data.Entities
{
    public class Employee:BaseEntity
    {
        
        [Required]  
        public String Fname { get; set; }
        public String Lname { get; set; }
        [MinLength(18)]
        [MaxLength(65)]
        public int age { get; set; }
        [StringLength(9)]
        public String CivilID_Number { get; set; }
        public Department department { get; set; }
        public int Dept_ID {  get; set; }
        public char Gender { get; set; } = 'M';
        
        public string Email { get; set; }
        [StringLength(9)]
        [Required]
        public string Phone_Number { get; set; }

    }
}
