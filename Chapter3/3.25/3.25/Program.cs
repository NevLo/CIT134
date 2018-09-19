using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: Christian Pilley
//Date: 9/19/18
//Desc: Calculates if num1 is a multiple of num2
namespace _3._25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 2 integer values: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"{(x % y == 0 ?  "Num 1 is a multiple of num 2" : "Num 1 is not a multiple of num 2" )}");
            Console.WriteLine($"{x} % {y} == {x % y}");
            Console.ReadKey();
        }
    }
}
