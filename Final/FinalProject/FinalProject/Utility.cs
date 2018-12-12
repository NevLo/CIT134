using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FinalProject
{
    public class Utility
    {
        public static Button[,] Buttons = new Button[10,10];
        public static Tile[,] cells = new Tile[10,10];
        public static Tile[] tilesWithBombs = new Tile[100];
        public static Label lbl1;
        static Random rand = new Random();

        public static void InitBombs()
        {

            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {

                    Buttons[i, j].Text = " ";
                    if(rand.NextDouble() > .8)
                    {
                        cells[i,j] = new Tile(i,j,true);
                        tilesWithBombs[Tile.numBombs] = cells[i, j];
                        Tile.numBombs++;
                    }
                    else
                    {
                        cells[i, j] = new Tile(i, j, false);
                    }
                    
                }
                
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    cells[i, j].countBombs();
                    //if(!cells[i,j].isBomb) Buttons[i, j].Text = cells[i, j].neighborCount.ToString();
                }

            }

        }
        public static void revealAllBombs()
        {
            foreach(Tile t in tilesWithBombs)
            {
                if (t != null)
                {
                    t.reveal();
                }
            }
        }
    }
}
