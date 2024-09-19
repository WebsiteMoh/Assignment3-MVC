using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.data
{
    public class ApplicationUsers :IdentityUser
    {
        public String FName { get; set; }
        public String Lname { get; set; }
        public bool IsAdmin { get; set; }
    }
}
