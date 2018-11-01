using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensions
{
    public class Program
    {
        public static Random rand = new Random();
        public static void Main(string[] args)
        {
            
            string[,] sides = new string[3,3];
            string[,] annoying = new string[12, 12];
            // Jagged Array
            int[][] numbers = new int[9][];
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new int[i+1];
            }

            foreach(int[] n in numbers)
            {
                foreach(int g in n)
                {
                    
                    Console.Write(numbers[n.Length - 1][g]);
                }
                Console.WriteLine();
            }



            InitializeArray(sides);
            InitializeArray(annoying);
            DisplayArray(sides);
            DisplayArray(annoying);
        }

        public static void InitializeArray(string[,] x)
        {
            for (int rows = 0; rows < x.GetLength(0); rows++)
            {
                for (int cols = 0; cols < x.GetLength(1); cols++)
                {
                    //x[rows, cols] = rand.Next(50) >= rand.Next(50) ? "X" : "O";
                    x[rows, cols] = rows + "," + cols + "\t";
                }

            }
        }
        public static void DisplayArray(string[,] x)
        {
            for (int rows = 0; rows < x.GetLength(0); rows++)
            {
                for (int cols = 0; cols < x.GetLength(1); cols++)
                {
                    Console.Write(x[rows, cols] + " ");

                }
                Console.WriteLine();
            }
        }
    }

}
