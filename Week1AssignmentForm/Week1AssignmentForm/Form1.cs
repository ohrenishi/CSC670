using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1AssignmentForm
{
    public partial class Form1 : Form

    {
        public Form1()
           
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputBox1.Clear();
            inputBox2.Clear();
            outputBox.Clear();
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            int sum = 0;

            sum = Convert.ToInt32(inputBox1.Text) + Convert.ToInt32(inputBox2.Text);

            outputBox.AppendText("The sum of " + inputBox1.Text + " and " + inputBox2.Text + " is " + Convert.ToString(sum));

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DifferenceButton_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            int diff = 0;

            diff = Convert.ToInt32(inputBox1.Text) - Convert.ToInt32(inputBox2.Text);


            outputBox.AppendText("The Difference of " + inputBox1.Text + " and " + inputBox2.Text + " is " + Convert.ToString(diff));

        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            int prod = 0;

            prod = Convert.ToInt32(inputBox1.Text) * Convert.ToInt32(inputBox2.Text);


            outputBox.AppendText("The Product of " + inputBox1.Text + " and " + inputBox2.Text + " is " + Convert.ToString(prod));

        }

        private void QuotientButton_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            double quot = 0;

            quot = Convert.ToDouble(inputBox1.Text) / Convert.ToDouble(inputBox2.Text);


            outputBox.AppendText("The Quotient of " + inputBox1.Text + " and " + inputBox2.Text + " is " + Convert.ToString(quot));

        }
    }
}
