using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] twoDArray = new int[10][];
            InitializeArray(twoDArray);
            SumArray(twoDArray);
            DisplayArray(twoDArray);

        }
        static void InitializeArray(int[][] a)
        {
            Random r = new Random();
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = new int[12];
                for(int j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = r.Next(1000);
                }
            }

        }
        static void SumArray(int[][] a)
        {
            int total = 0;
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < a[i].Length; j++)
                {
                    total += a[i][j];
                }
            }
            Console.WriteLine(total);
        }
        static void DisplayArray(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }


    }
}
