using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseTests
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input from user
            Console.Write("How many grades do you want to enter?: ");
            int count = int.Parse(Console.ReadLine());
            //bool run = true;

            float total = 0;
            while (0 != count) {

                


                // Input from user
                Console.Write("Please enter your grade percentage: ");
                float perc = float.Parse(Console.ReadLine());

                total += perc;
                
                // Logical Buisness
                if (perc < 0)
                {
                    Console.WriteLine("Input between 0 and 100");
                }
                else if (perc < 60)
                {
                    Console.WriteLine("You got an F...");
                }
                else if (perc < 70)
                {
                    Console.WriteLine("You got a D...");
                }
                else if (perc < 80)
                {
                    Console.WriteLine("You got a C...");
                }
                else if (perc < 90)
                {
                    Console.WriteLine("You got a B...");
                }
                else if (perc <= 100)
                {
                    Console.WriteLine("You got an A...");
                    if (perc > 95)
                    {
                        Console.WriteLine("you get a free choclate bar");

                    }
                    if (perc > 98.5)
                    {
                        Console.WriteLine("Get your chocolate and meet me in the parking lot.");
                        if (perc is 100)
                        {
                            Console.WriteLine("You get to drive!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Input between 0 and 100");
                }
                // Modify the iterator.
                count--;
            }
        }
    }
}
