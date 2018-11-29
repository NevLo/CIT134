using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            TestingThings t1 = new TestingThings(12, "Frodo is chill");
            Console.WriteLine("Test Num: {0}", t1.TestNum);

            t1.NumberOfTests = 900000000;
            Console.WriteLine("Number of Tests: {0}", t1.getNumberOfTests());

            Console.WriteLine("4 * PI {0}", 4 * TestingThings.PI);

            Console.WriteLine("Test Name: {0}", t1.TestName);

            try
            {
                t1.InputByte(9, 0);
                t1.InputByte(2, 1);
                t1.InputByte(5, 2);
                t1.InputByte(8, 3);
                t1.InputByte(9, 4);
                t1.InputByte(2, 5);
                t1.InputByte(5, 6);
                t1.InputByte(6, 7);
                t1.InputByte(6, 8);
                t1.InputByte(7, 9);
                t1.InputByte(1, 5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Large number: {0}", t1);


            Console.WriteLine("Goodbye!");
        }
    }
}
