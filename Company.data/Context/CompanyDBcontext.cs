using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.data.Entites;
using Company.data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Company.data.Context
{
    public class CompanyDBcontext : IdentityDbContext<ApplicationUsers>
    {
        public CompanyDBcontext()
        {

        }
        public CompanyDBcontext(DbContextOptions<CompanyDBcontext> options): base(options) {
        
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //   optionsBuilder.UseSqlServer("");
        //}
    
      public DbSet<Employee> Employees { get; set; }
        public DbSet<Departments> Department { get; set; }


    }
}
