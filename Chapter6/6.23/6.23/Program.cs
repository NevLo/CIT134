using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: Christian Pilley
//Desc: Makes a diamond with 3 forloops and 2 CW's
//Date: 10/10/18
namespace _6._23
{
    class Program
    {
        static void Main(string[] args)
        {
            //outer loop
            int ask = 1;
            int space = 4;
            bool forward = true;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < space; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < ask; j++)
                {
                    Console.Write('*');

                }
                if (forward == false)
                {
                    ask -= 2;
                    space++;
                }
                else
                {
                    ask += 2;
                    space--;
                    if (ask == 9) forward = false;
                }
                Console.WriteLine();
            }
        }
    }
}
