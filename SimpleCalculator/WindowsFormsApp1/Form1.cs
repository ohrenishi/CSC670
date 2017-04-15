using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            int sum = 0;

            if(textBox1.Text == null && textBox2.Text == null)
            {
                throw new Exception("Test");
            }
            try
            {
                sum = Convert.ToInt32(textBox1.Text) +
                        Convert.ToInt32(textBox2.Text);

                textBox3.AppendText("The sum of " + textBox1.Text + " and " + 
                    textBox2.Text + " is " + Convert.ToString(sum));
            }
            catch (Exception ex)
            {
                textBox3.AppendText("Please Enter Numbers to Compute");
            }
}

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            int diff = 0;
            try { 
                diff = Convert.ToInt32(textBox1.Text) -
                        Convert.ToInt32(textBox2.Text);

                textBox3.AppendText("The Difference of " + textBox1.Text + " and " +
                    textBox2.Text + " is " + Convert.ToString(diff));
            }
            catch (System.FormatException)
            {
                textBox3.AppendText("Please Enter Numbers to Compute");
            }
}

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            int prod = 0;
            try { 
                prod = Convert.ToInt32(textBox1.Text) *
                    Convert.ToInt32(textBox2.Text);
            
                textBox3.AppendText("The Product of " + textBox1.Text + " and " +
                    textBox2.Text + " is " + Convert.ToString(prod));
            }
            catch (System.FormatException)
            {
                textBox3.AppendText("Please Enter Numbers to Compute");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            double quot= 0;

            try
            {
                quot = Convert.ToDouble(textBox1.Text) /
                        Convert.ToDouble(textBox2.Text);

                textBox3.AppendText("The Product of " + textBox1.Text + " and " +
                    textBox2.Text + " is " + Convert.ToString(quot));
            }
            
            catch (System.Exception)
            {
                textBox3.AppendText("There is some error or Cannot divide by zero");
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
