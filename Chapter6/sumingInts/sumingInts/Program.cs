using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumingInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for(int i = 0; i <= 66; i += 3) total += i;
            Console.WriteLine(total);

      
        }
    }
}
