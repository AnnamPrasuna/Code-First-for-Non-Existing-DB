using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFAFNED
{
    internal class EmployeeContext:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set;}
    }
}
