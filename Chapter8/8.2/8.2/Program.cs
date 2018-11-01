using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            double[] arr = new double[25];
            InitializeArray(arr);
            DisplayArray(arr);




        }
        public static void InitializeArray(double[] d)
        {
            for(int i = 0; i < d.Length; i++)
            {
                d[i] = rand.NextDouble();
            }
        }

        public static void DisplayArray(double[] d)
        {
            foreach(double de in d){
                Console.WriteLine(de);

            }
        }
    }
}
