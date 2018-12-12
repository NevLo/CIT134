using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        private bool gameOver = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitButtons();
            Utility.InitBombs();
            label3.Text = (Tile.numBombs - Tile.numTilesFlagged).ToString();
        }



        public void InitButtons()
        {
            Utility.lbl1 = label1;
            Utility.Buttons[0, 0] = button1;
            Utility.Buttons[0, 1] = button2;
            Utility.Buttons[0, 2] = button3;
            Utility.Buttons[0, 3] = button4;
            Utility.Buttons[0, 4] = button5;
            Utility.Buttons[0, 5] = button6;
            Utility.Buttons[0, 6] = button7;
            Utility.Buttons[0, 7] = button8;
            Utility.Buttons[0, 8] = button9;
            Utility.Buttons[0, 9] = button10;
            Utility.Buttons[1, 0] = button11;
            Utility.Buttons[1, 1] = button12;
            Utility.Buttons[1, 2] = button13;
            Utility.Buttons[1, 3] = button14;
            Utility.Buttons[1, 4] = button15;
            Utility.Buttons[1, 5] = button16;
            Utility.Buttons[1, 6] = button17;
            Utility.Buttons[1, 7] = button18;
            Utility.Buttons[1, 8] = button19;
            Utility.Buttons[1, 9] = button20;
            Utility.Buttons[2, 0] = button21;
            Utility.Buttons[2, 1] = button22;
            Utility.Buttons[2, 2] = button23;
            Utility.Buttons[2, 3] = button24;
            Utility.Buttons[2, 4] = button25;
            Utility.Buttons[2, 5] = button26;
            Utility.Buttons[2, 6] = button27;
            Utility.Buttons[2, 7] = button28;
            Utility.Buttons[2, 8] = button29;
            Utility.Buttons[2, 9] = button30;
            Utility.Buttons[3, 0] = button31;
            Utility.Buttons[3, 1] = button32;
            Utility.Buttons[3, 2] = button33;
            Utility.Buttons[3, 3] = button34;
            Utility.Buttons[3, 4] = button35;
            Utility.Buttons[3, 5] = button36;
            Utility.Buttons[3, 6] = button37;
            Utility.Buttons[3, 7] = button38;
            Utility.Buttons[3, 8] = button39;
            Utility.Buttons[3, 9] = button40;
            Utility.Buttons[4, 0] = button41;
            Utility.Buttons[4, 1] = button42;
            Utility.Buttons[4, 2] = button43;
            Utility.Buttons[4, 3] = button44;
            Utility.Buttons[4, 4] = button45;
            Utility.Buttons[4, 5] = button46;
            Utility.Buttons[4, 6] = button47;
            Utility.Buttons[4, 7] = button48;
            Utility.Buttons[4, 8] = button49;
            Utility.Buttons[4, 9] = button50;
            Utility.Buttons[5, 0] = button51;
            Utility.Buttons[5, 1] = button52;
            Utility.Buttons[5, 2] = button53;
            Utility.Buttons[5, 3] = button54;
            Utility.Buttons[5, 4] = button55;
            Utility.Buttons[5, 5] = button56;
            Utility.Buttons[5, 6] = button57;
            Utility.Buttons[5, 7] = button58;
            Utility.Buttons[5, 8] = button59;
            Utility.Buttons[5, 9] = button60;
            Utility.Buttons[6, 0] = button61;
            Utility.Buttons[6, 1] = button62;
            Utility.Buttons[6, 2] = button63;
            Utility.Buttons[6, 3] = button64;
            Utility.Buttons[6, 4] = button65;
            Utility.Buttons[6, 5] = button66;
            Utility.Buttons[6, 6] = button67;
            Utility.Buttons[6, 7] = button68;
            Utility.Buttons[6, 8] = button69;
            Utility.Buttons[6, 9] = button70;
            Utility.Buttons[7, 0] = button71;
            Utility.Buttons[7, 1] = button72;
            Utility.Buttons[7, 2] = button73;
            Utility.Buttons[7, 3] = button74;
            Utility.Buttons[7, 4] = button75;
            Utility.Buttons[7, 5] = button76;
            Utility.Buttons[7, 6] = button77;
            Utility.Buttons[7, 7] = button78;
            Utility.Buttons[7, 8] = button79;
            Utility.Buttons[7, 9] = button80;
            Utility.Buttons[8, 0] = button81;
            Utility.Buttons[8, 1] = button82;
            Utility.Buttons[8, 2] = button83;
            Utility.Buttons[8, 3] = button84;
            Utility.Buttons[8, 4] = button85;
            Utility.Buttons[8, 5] = button86;
            Utility.Buttons[8, 6] = button87;
            Utility.Buttons[8, 7] = button88;
            Utility.Buttons[8, 8] = button89;
            Utility.Buttons[8, 9] = button90;
            Utility.Buttons[9, 0] = button91;
            Utility.Buttons[9, 1] = button92;
            Utility.Buttons[9, 2] = button93;
            Utility.Buttons[9, 3] = button94;
            Utility.Buttons[9, 4] = button95;
            Utility.Buttons[9, 5] = button96;
            Utility.Buttons[9, 6] = button97;
            Utility.Buttons[9, 7] = button98;
            Utility.Buttons[9, 8] = button99;
            Utility.Buttons[9, 9] = button100;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                MouseEventArgs me = (MouseEventArgs)e;
                
                for (int i = 0; i < 10; i++)
                {

                    for (int j = 0; j < 10; j++)
                    {
                        if (Utility.Buttons[i, j] == sender)
                        {
                            if (me.Button == MouseButtons.Left)
                            {
                                if (Control.ModifierKeys == Keys.Shift) {
                                    Utility.cells[i, j].flag();
                                    Tile.numTilesFlagged++;
                                    label3.Text = (Tile.numBombs - Tile.numTilesFlagged).ToString();
                                    if (Utility.cells[i, j].isBomb)
                                    {
                                        Tile.numBombsFlagged++;
                                    }
                                    
                                }
                                else {
                                    Utility.cells[i, j].reveal();
                                    if (Utility.cells[i, j].isBomb)
                                    {
                                        gameOver = true;
                                        label2.Visible = true;
                                        InitButton.Visible = true;
                                        Utility.revealAllBombs();
                                        showStuffs();
                                    }
                                }
                                if(Tile.numTilesFlagged == Tile.numBombsFlagged && Tile.numBombsFlagged-Tile.numBombs == 0)
                                {
                                    gameOver = true;
                                    label1.Visible = true;
                                    InitButton.Visible = true;
                                    showStuffs();
                                }
                            }
                        }//END IF
                    }//END FOR
                }//END FOR
                
            }//END IF
        }//END METHOD

        private void InitButton_Click(object sender, EventArgs e)
        {
            clearScreen();
            Utility.Buttons.Initialize();
            Utility.cells.Initialize();
            Utility.tilesWithBombs.Initialize();
            Tile.numBombs = 0;
            Tile.numBombsFlagged = 0;
            Tile.numTilesFlagged = 0;
            Form1_Load(sender, e);
            gameOver = false;
            label2.Visible = false;
            label1.Visible = false;
            InitButton.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void clearScreen()
        {
            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Utility.Buttons[i, j].Text = " ";
                    Utility.Buttons[i, j].BackColor = System.Drawing.Color.White;
                    Utility.Buttons[i, j].UseVisualStyleBackColor = true;
                }
            }
        }
        public void showStuffs()
        {
            string temp = LongString();
            MessageBox.Show(temp);
        }
        public string LongString()
        {
            string temp = "";
            for(int i =0; i < 10; i++)
            {
                for(int j =0; j < 10; j++)
                {
                    temp += Utility.cells[i, j].ToString() + " ";
                }
                temp += "\n";
            }
            return temp;
        }
    }
}

