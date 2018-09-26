using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._11
{
    class Employee
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        private decimal salary;
        public decimal Salary {
            get
            {
                return salary;
            }
            set
            {
                if (value < 0)
                {
                   // Console.Write(Math.Abs(salary) + " != " + salary);
                    salary = 0;
                }
                else
                {
                    salary = value;
                }
            }
        }


        public Employee(string f, string l)
        {
            Fname = f;
            Lname = l;
            salary = 0;
        }
    }
}
