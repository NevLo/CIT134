using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._11
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            Employee a = new Employee("Alex", "Jones");
            Employee b = new Employee("Jason", "Borne");
            a.Salary = 1000000000M;
            b.Salary = -1000M;
            Console.WriteLine("Employee A Salary: " + (a.Salary * 12));
            Console.WriteLine("Employee B Salary: " + (b.Salary * 12));
            Console.WriteLine("Time for a 10% raise!");

            a.Salary *= 1.1M;
            b.Salary *= 1.1M;


            Console.WriteLine("Employee A Salary: " + a.Salary * 12);
            Console.WriteLine("Employee B Salary: " + b.Salary * 12);

        }
    }
}
