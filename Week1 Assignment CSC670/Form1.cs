using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            int sum = 0;
            try
            {
                sum = Convert.ToInt32(inputTextBox1.Text) + Convert.ToInt32(inputTextBox2.Text);
                resultRichTextBox1.AppendText("The sum of " + inputTextBox1.Text + " and " + inputTextBox2.Text + " is " + Convert.ToString(sum));
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Please enter a number!");
            }

        }

        private void differenceButton_Click(object sender, EventArgs e)
        {
            int diff = 0;
            try { 

            diff = Convert.ToInt32(inputTextBox1.Text) - Convert.ToInt32(inputTextBox2.Text);
            resultRichTextBox1.AppendText("The Difference of " + inputTextBox1.Text + " and " + inputTextBox2.Text + " is " + Convert.ToString(diff));

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Please enter a number!");
            }

        }

        private void productButton_Click(object sender, EventArgs e)
        {
            int prod = 0;
            try {
                prod = Convert.ToInt32(inputTextBox1.Text) * Convert.ToInt32(inputTextBox2.Text);

                resultRichTextBox1.AppendText("The Product of " + inputTextBox1.Text + " and " + inputTextBox2.Text + " is " + Convert.ToString(prod));
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Please enter a number!");
            }

        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            double divide = 0;
            try {
                divide = Convert.ToDouble(inputTextBox1.Text) / Convert.ToDouble(inputTextBox2.Text);
                resultRichTextBox1.AppendText("The Quotient of " + inputTextBox1.Text + " and " + inputTextBox2.Text + " is " + Convert.ToString(divide));
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Please enter a number!");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextBox1.Clear();
            inputTextBox2.Clear();
            resultRichTextBox1.Clear();
       
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }


    }
}
