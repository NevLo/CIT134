using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: Christian Pilley
//Date: 9/19/18
//Desc: num/square/cube table for numbers 0 to 10
namespace _3._29
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Number\tSquare\tCube\t");
            Console.WriteLine($"{x}\t{x * x}\t{x * x * x}");
            x++;
            Console.WriteLine($"{x}\t{x * x}\t{x * x * x}");
            x++;
            Console.WriteLine($"{x}\t{x * x}\t{x * x * x}");
            x++;
            Console.WriteLine($"{x}\t{x * x}\t{x * x * x}");
            x++;
            Console.WriteLine($"{x}\t{x * x}\t{x * x * x}");
            x++;
            Console.WriteLine($"{x}\t{x * x}\t{x * x * x}");
            x++;
            Console.WriteLine($"{x}\t{x * x}\t{x * x * x}");
            x++;
            Console.WriteLine($"{x}\t{x * x}\t{x * x * x}");
            x++;
            Console.WriteLine($"{x}\t{x * x}\t{x * x * x}");
            x++;
            Console.WriteLine($"{x}\t{x * x}\t{x * x * x}");
            x++;
            Console.WriteLine($"{x}\t{x * x}\t{x * x * x}");
            Console.ReadKey();
        }
    }
}
