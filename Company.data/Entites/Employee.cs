using Company.data.Entites;
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
        public int Id { get; set; }
        [Required]  
        public String Fname { get; set; }
        public String Lname { get; set; }
    
        public int age { get; set; }
        [StringLength(9)]
        public String CivilID_Number { get; set; }
        public String Email { get; set; }
        [StringLength(9)]
        [Required]
        public String Phone_Number { get; set; }

        public int? Dep_ID { get; set; }
        public String ImgURL { get; set; }

  

    }
}
