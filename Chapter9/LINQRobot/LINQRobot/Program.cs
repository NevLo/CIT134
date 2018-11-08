using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            nums.Count();
            nums.Add(123);
            nums.Add(555);
            nums.Add(777);
            nums.Add(999);
          
            foreach(var i in nums)
            {
                Console.WriteLine(i);
            }
            nums.Remove(555);
            Console.WriteLine(  );
            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }
            

            Console.WriteLine();
            Console.WriteLine();
            var rob = new Robot[] {

                new Robot("Beth", 1234.5678M, 'A'),
                new Robot("Fred", 4234.5678M, 'F'),
                new Robot("Lisa", 3234.5678M, 'T'),
                new Robot("Lisa", 6234.5678M, 'A'),
                new Robot("Fred", 3234.5678M, 'X'),
                new Robot("John", 2234.5678M, 'T'),
                new Robot("Joan", 9234.5678M, 'A'),
                new Robot("Mark", 9234.5678M, 'A')

               

            };
            DisplayInfo("Original Array", rob);
            var modelARobots =
                from m in rob
                where m.Model == 'A'
                select m;
            DisplayInfo("Model A Robots", modelARobots);
            var middlePriceRobots =
                from r in rob
                where r.Price >= 2000 && r.Price <= 8000
                select r;
            DisplayInfo("Middle Priced robots", middlePriceRobots);

            var middModT =
                from r in middlePriceRobots
                where r.Model.Equals('T')
                select r.Name;
            DisplayInfo("Middle T's", middModT);

            Console.ReadKey();
        }
        private static void DisplayInfo(string title, IEnumerable<Object> collection)
        {
            Console.WriteLine(title);
            foreach (var r in collection)
            {
                Console.WriteLine(r);
            }
            
            //Console.WriteLine(r.ToString());
            Console.WriteLine("");

        }
    }
}
