using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float temp;
        float temp2;
        char op = ' ';
        float ans;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TB1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TB1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TB1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TB1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TB1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TB1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TB1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TB1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TB1.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            TB1.Text += '0';
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TB1.Text += " + ";
            
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            TB1.Text += " - ";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            TB1.Text += " * ";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            TB1.Text += " / ";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            op = getChar(TB1.Text);
            temp = float.Parse(TB1.Text.Substring(0, TB1.Text.IndexOf(op)));
            Console.WriteLine(TB1.Text);
            temp2 = float.Parse(TB1.Text.Substring(TB1.Text.IndexOf(op) + 1));
            switch (op)
            {
                case '+':
                    ans = temp + temp2;
                    TB1.Text = ans.ToString();
                    break;
                case '-':
                    ans = temp - temp2;
                    TB1.Text = ans.ToString();
                    break;
                case '/':
                    ans = temp / temp2;
                    TB1.Text = ans.ToString();
                    break;
                case '*':
                    ans = temp * temp2;
                    TB1.Text = ans.ToString();
                    break;
            }
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            TB1.Text += ".";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {

        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TB1_TextChanged(object sender, EventArgs e)
        {

        }
        private char getChar(String text)
        {
            if (text.Contains("+"))
            {
                return '+';
            }
            else if (text.Contains("-"))
            {
                return '-';
            }
            else if (text.Contains("*"))
            {
                return '*';
            }
            else if (text.Contains("/"))
            {
                return '/';
            }
            return ' ';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
