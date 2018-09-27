using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalcMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 3;
            while (choice != 0)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("Menu");
                Console.WriteLine("--------------------");
                Console.WriteLine("-1 message");
                Console.WriteLine();
                Console.WriteLine("-2 calculator");
                Console.WriteLine();
                Console.WriteLine("-0 exit");
                Console.WriteLine("--------------------");

                Console.Write(">>> ");


                choice = int.Parse(Console.ReadLine());

                if(choice is 1)
                {
                    Console.WriteLine("Please enter a number between 1 and 10");
                    Console.Write(">>> ");
                    int num = int.Parse(Console.ReadLine());
                    while(num != 0)
                    {
                        num--;
                        Console.WriteLine("Hello!");
                    }
                }
                else if(choice is 2)
                {
                    Console.WriteLine("Please enter 2 numbers");
                    Console.Write(">>> ");
                    int num = int.Parse(Console.ReadLine());
                    Console.Write(">>> ");
                    int num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine($"{num} * {num2} = {num * num2}");
                }
                else if(choice is 0)
                {
                    Console.WriteLine("Exiting program!");
                }
                else
                {
                    Console.WriteLine("Please enter 0, 1, or 2!");
                }


            }
        }
    }
}
