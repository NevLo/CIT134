using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Tile
    {
        public int x;
        public int y;
        public bool isBomb;
        public bool isRevealed;
        public bool isFlagged;
        public int neighborCount;
        public static int numBombs = 0;
        public static int numTilesFlagged = 0;
        public static int numBombsFlagged = 0;

        public Tile()
        {

        }
        public Tile(int x, int y, bool isBomb)
        {
            this.x = x;
            this.y = y;
            this.isBomb = isBomb;
        }
        public void countBombs()
        {
            if (this.isBomb)
            {
                neighborCount = -1;
                return;
            }
            if (this.isRevealed)
            {
                return;
            }
            int total = 0;
            for (int _i = -1; _i <= 1; _i++)
            {
                for (int _j = -1; _j <= 1; _j++)
                {
                    int i = this.x + _i;
                    int j = this.y + _j;
                    if (i >= 0 && i < 10 && j >= 0 && j < 10)
                    {
                        
                        if (Utility.cells[i, j].isBomb)
                        {
                            total++;
                        }
                        neighborCount = total;

                    }
                }

            }

        }

        public void reveal()
        {
            if (isRevealed || isFlagged) { return; }
            if (neighborCount != -1)
            {
                Utility.cells[x, y].isRevealed = true;
                Utility.Buttons[x, y].Text = neighborCount.ToString();
                if (neighborCount == 0)
                {
                    for (int _i = -1; _i <= 1; _i++)
                    {
                        for (int _j = -1; _j <= 1; _j++)
                        {
                            int i = this.x + _i;
                            int j = this.y + _j;
                            if (i >= 0 && i < 10 && j >= 0 && j < 10)
                            {
                                Utility.cells[i, j].reveal();
                              

                            }
                        }

                    }
                }
            }
            else Utility.Buttons[x, y].Text = "B";
        }

        public void flag()
        {
            if (!isFlagged && !isRevealed)
            {
                isFlagged = true;
                Utility.Buttons[x, y].UseVisualStyleBackColor = false;
                Utility.Buttons[x, y].BackColor = System.Drawing.Color.Red;
                Utility.Buttons[x, y].Text = "F";
            }
            else if(isFlagged)
            {
                isFlagged = false;
                Utility.Buttons[x, y].Text = " ";
                Utility.Buttons[x, y].BackColor = System.Drawing.Color.White;
                Utility.Buttons[x, y].UseVisualStyleBackColor = true;
            }
        }
        public override string ToString()
        {
            return $"Tile: {x},{y} isBomb: {(isBomb ? "Y":"N")}      |";
        }
    }
}
