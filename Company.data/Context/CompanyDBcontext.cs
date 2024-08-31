using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Company.data.Context
{
    public class CompanyDBcontext : DbContext
    {
        public CompanyDBcontext(DbContextOptions<CompanyDBcontext> options): base(options) {
        
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //   optionsBuilder.UseSqlServer("");
        //}
    
      public DbSet<Employee> Employees { get; set; }
       public DbSet<Department> Departments { get; set; }

    }
}
