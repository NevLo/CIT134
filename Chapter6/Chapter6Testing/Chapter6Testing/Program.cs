using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter;
            for (counter = 10; counter >= 0; counter -= 2)
            {
                Console.Write($"{counter} ");

            }
             Console.WriteLine(counter);



            int total = 0;
            for (int i = 0; i <= 66; i += 3) total += i;
            Console.WriteLine(total);

            decimal amount = 2345.6789m;
            int year = 2018;

            Console.WriteLine($"{year,4} {amount, 20:c}");

            int count = 1;
            
            do
            {
                Console.WriteLine($"{count++}");
            } while (count <= 10);

            string name = "Someone's Name";
            char oneChar = 'C';

            for(int h = 0; h <name.Length; h++)
            {
                Console.Write(h + " ");
            }


        }
    }
}
