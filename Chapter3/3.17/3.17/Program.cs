using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: Christian Pilley
//Date: 9/19/18
//Desc: Finds sum, average, product, min and max of 3 integers.
namespace _3._17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter 3 integers: ");
            int x, y, z;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum: {x + y + z}");
            Console.WriteLine($"Average: {(x + y + z)/3}");
            Console.WriteLine($"Product: {x * y * z}");
            Console.WriteLine($"Max: {Math.Max(x, Math.Max(y, z))}");
            Console.WriteLine($"Min: {Math.Min(x, Math.Min(y, z))}");


            Console.ReadKey();
        }
    }
}
