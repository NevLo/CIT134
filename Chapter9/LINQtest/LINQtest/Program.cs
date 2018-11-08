using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 23, 4, -4, 0, 7,
                0, -3, 1, 2, 5, 100, -1};
            //get numbers greater than 0
            var numbersGreaterThanZero =
                // from clause = range variable
                // and what data source
                (from num in numbers
                // where is true, num is included
                where num > 0
                //order by 
                orderby num descending
                //select clause decides what is selected
                select num).Distinct();

            foreach (var n in numbersGreaterThanZero)
            {
                Console.WriteLine(n);
            }

        }
    }
}
