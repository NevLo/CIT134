using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;
            Console.Write("Please enter the first num: ");
            firstNum = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second num: ");
            secondNum = Convert.ToInt32(Console.ReadLine());

            if(firstNum < 0)
            {
                Console.WriteLine("Hey!");
                Console.WriteLine("That number is too small");
            }
        }
    }
}
