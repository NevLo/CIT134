using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//name: Christian Pilley
//desc: Loop to show table
//date: 10/3/18 15:34
namespace _5._22
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = 1;
            Console.WriteLine("N\t10*N\t100*N\t1000*N\n");
            while (loop <= 5){
                Console.WriteLine($"{loop}\t{loop * 10}\t{loop * 100}\t{loop * 1000}");
                loop++;
            }




        }
    }
}
