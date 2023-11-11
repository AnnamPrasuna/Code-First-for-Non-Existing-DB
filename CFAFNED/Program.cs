using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFAFNED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeContext empctx = new EmployeeContext();
            Employee emp = new Employee()
            {
                EmployeeId = 1, EmployeeName = "Prasuna", Salary = 18000,Department="MCB"
            };
            empctx.Employees.Add(emp);
            empctx.SaveChanges();
            Console.WriteLine("Employee Data Added Successfully");
            Console.ReadKey();

        }
    }
}
