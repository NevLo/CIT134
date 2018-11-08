using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Color randColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            BackColor = randColor;

            string tb3 = textBox1.Text + textBox2.Text + textBox3.Text;
            label1.Text = tb3;
            SumNumbers();
        }
        private void SumNumbers()
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            MessageBox.Show("Result is " + (num1 + num2));
        }
        
    }
}
