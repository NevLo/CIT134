using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompTesting
{
    public partial class Form1 : Form
    {
        private List<Person> people;

        public Form1()
        {
            InitializeComponent();
            people = new List<Person>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var person = new Person()
                {
                    FirstName = textBox1.Text,
                    LastName = textBox2.Text,
                    Age = uint.Parse(textBox3.Text)
                };
                people.Add(person);
                MessageBox.Show("Added!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            foreach (var p in people) {
                MessageBox.Show(p.FirstName + " " + p.LastName + " " + p.Age);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                people.RemoveAt(int.Parse(textBox4.Text));
                MessageBox.Show("Removed");
            }catch(Exception ex)
            {

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }
    }
}
