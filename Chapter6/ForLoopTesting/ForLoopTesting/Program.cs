using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            for(uint i = 10; i >= 0; i -= 2)
            {
                Console.Write($"{i} ");
                
            }
           // Console.WriteLine(i);
        }
    }
}
