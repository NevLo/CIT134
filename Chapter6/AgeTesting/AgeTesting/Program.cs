using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int weight;
            int height;
            Console.Write("Please enter your age\n>>>");
            age = int.Parse(Console.ReadLine());
            Console.Write("Please enter your weight\n>>>");
            weight = int.Parse(Console.ReadLine());
            Console.Write("Please enter your height\n>>>");
            height = int.Parse(Console.ReadLine());
            if (age > 35 && weight > 180|| height > 72)
            {
                Console.WriteLine("Get your eyes checked");
            }

        }
    }
}
