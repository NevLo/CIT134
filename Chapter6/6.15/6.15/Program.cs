using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(a)\t\t(b)\t\t(c)\t\t(d)");
            for (int counter = 1; counter <= 10; ++counter)
            {
                //(a)
                for (int i = 1; i <= counter; i++) { Console.Write('*'); }
                Console.Write("\t");
                if (counter < 8) Console.Write("\t");
                //(b)
                for (int i = 10; i >= counter; i--) { Console.Write('*');}
                Console.Write("\t");
                if (counter >= 4) Console.Write("\t");
                //(c)
                for (int i = 0; i <= counter; i++)
                {
                    //Console.Write(i);
                    if(i != 0) Console.Write(' ');
                }
                for (int j = 0; j <= 10 - counter; j++)
                {
                    Console.Write('*');
                }
                //(d)
                Console.Write("\t");
                
                for (int i = 10; i > counter; i--)
                {
                    //Console.Write(i);
                    if (i != 0) Console.Write(' ');
                }
                for (int j = 0; j < counter; j++)
                {
                    Console.Write('*');
                }


                Console.WriteLine();
            }
        }
    }
}
