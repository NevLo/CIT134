using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: Christian Pilley
//Date: 9/19/18
//Desc: Draws a square, oval, arrow, and diamond out of asterisks
namespace _3._18
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] square  = new string[9];
            string[] oval    = new string[9];
            string[] arrow   = new string[9];
            string[] diamond = new string[9];

            square[0] = "*********";
            square[1] = "*       *";
            square[2] = "*       *";
            square[3] = "*       *";
            square[4] = "*       *";
            square[5] = "*       *";
            square[6] = "*       *";
            square[7] = "*       *";
            square[8] = "*********";

            oval[0] = "   ***   ";
            oval[1] = " *     * ";
            oval[2] = "*       *";
            oval[3] = "*       *";
            oval[4] = "*       *";
            oval[5] = "*       *";
            oval[6] = "*       *";
            oval[7] = " *     * ";
            oval[8] = "   ***   ";

            arrow[0] = "    *    ";
            arrow[1] = "   ***   ";
            arrow[2] = "  *****  ";
            arrow[3] = "    *    ";
            arrow[4] = "    *    ";
            arrow[5] = "    *    ";
            arrow[6] = "    *    ";
            arrow[7] = "    *    ";
            arrow[8] = "    *    ";

            diamond[0] = "    *    ";
            diamond[1] = "   * *   ";
            diamond[2] = "  *   *  ";
            diamond[3] = " *     * ";
            diamond[4] = "*       *";
            diamond[5] = " *     * ";
            diamond[6] = "  *   *  ";
            diamond[7] = "   * *   ";
            diamond[8] = "    *    ";

            Console.WriteLine($" {square[0]} {oval[0]} {arrow[0]} {diamond[0]} ");
            Console.WriteLine($" {square[1]} {oval[1]} {arrow[1]} {diamond[1]} ");
            Console.WriteLine($" {square[2]} {oval[2]} {arrow[2]} {diamond[2]} ");
            Console.WriteLine($" {square[3]} {oval[3]} {arrow[3]} {diamond[3]} ");
            Console.WriteLine($" {square[4]} {oval[4]} {arrow[4]} {diamond[4]} ");
            Console.WriteLine($" {square[5]} {oval[5]} {arrow[5]} {diamond[5]} ");
            Console.WriteLine($" {square[6]} {oval[6]} {arrow[6]} {diamond[6]} ");
            Console.WriteLine($" {square[7]} {oval[7]} {arrow[7]} {diamond[7]} ");
            Console.WriteLine($" {square[8]} {oval[8]} {arrow[8]} {diamond[8]} ");
            Console.ReadKey();
        }
       
    }
}
