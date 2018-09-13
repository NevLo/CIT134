using System;
using System.Threading;
namespace TestingApplication
{
    //Please add 'public' to your class declarations
    
    public class Supercoolthreads
    {
        private static char CMD = 'a';

        /*We added public to this method declaration as well */
        public static void Main(string[] args)
        {
            //Variable dec
            string name = "beth";
            string lname;
            int num1 = 4;
            int num2 = 10;
            int result;

            
            // string interpolation!
            Console.Write("Please enter a last name: ");
            lname = Console.ReadLine();
            Console.WriteLine($"Hello {name} {lname}");

            //prompt for values
            Console.Write("Please enter num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter num2: ");
            string temp = Console.ReadLine();
            num2 = int.Parse(temp);

            //Add two variables and display results
            result = num1 / num2;
            Console.WriteLine($"{num1} / {num2} is {result}");
            
            
            //Prevents app from exiting without permission from user
            Console.ReadKey();
          
        }

      
       
    }
}
