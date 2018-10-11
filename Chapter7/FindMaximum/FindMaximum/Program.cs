using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TianNotHere;
namespace FindMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindMax(1, 10, 5));
            Console.WriteLine(FindMax(100, 10, 5));
            Console.WriteLine(FindMax(1, 10, 50));
            JunkClass jc = new JunkClass();
        }

        public static int FindMax(int one, int two, int three)
        {
            if(one < two)
            {
                one = two;
                
            }
            if (one < three)
            {
                one = three;
             }
            return one;
        }




    }
}
