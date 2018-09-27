using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int loopContinue = 0;
            while (loopContinue >= 0) {
                // Ask user for their age

                Console.WriteLine("Welcome to age repetition");
                Console.Write("Please enter your age: ");

                // Assign age to a variable
                int age = int.Parse(Console.ReadLine());

                // Check if age is less than 0 
                // If less than 0 exit the while loop

                if (age < 0)
                {
                    loopContinue = age;


                }
                // If greater than 0 display the age age times
                // And repeat the program
                else
                {
                    int count = 0;
                    while (count < age) { Console.Write(age + " "); count++; }
                    Console.WriteLine();
                }
            }
        }
    }
}
