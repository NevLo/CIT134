using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Game
    {
        private bool isWinner;

        public bool IsWinner { get => isWinner; set => isWinner = value; }

        public Game()
        {
            Random rand = new Random();
            int x = rand.Next(2);
            if(x is 1)
            {
                IsWinner = true;
            }
        }




    }
}
