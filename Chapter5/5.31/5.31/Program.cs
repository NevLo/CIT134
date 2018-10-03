using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: Christian Pilley
//date: 10/3/18 :: 16:12
//desc: Palindrome of numbers checker



namespace _5._31
{
    class Program
    {
        static void Main(string[] args)
        {
            int zDigit;
            int ODigit;
            int sDigit;
            int tDigit;
            int fDigit;
            Console.Write("Please enter a 5 digit number: ");

            int num = int.Parse(Console.ReadLine());
            if (Math.Floor(Math.Log10(num) + 1) == 5)
            {
                int number = num;
                fDigit = num % 10;
                num /= 10;
                tDigit = num % 10;
                num /= 10;
                sDigit = num % 10;
                num /= 10;
                ODigit = num % 10;
                num /= 10;
                zDigit = num % 10;


                Console.WriteLine($"{zDigit}\t{ODigit}\t{sDigit}\t{tDigit}\t{fDigit}");
                if (zDigit == fDigit)
                {
                    if (ODigit == tDigit)
                    {
                        Console.WriteLine($"{number} is a palindrome!");
                        return;
                    }
                }
                Console.WriteLine("Not A Palindrome!");
            }
            else
            {
                Console.WriteLine("Make sure its 5 digits!!!");
                Console.ReadKey();
                Main(args);
            }
        }
    }
}
