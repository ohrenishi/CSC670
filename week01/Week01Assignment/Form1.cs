using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week01Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirst.Text = "";
            txtSecond.Text = "";
            txtResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSumm_Click(object sender, EventArgs e)
        {
            double num1 = Double.Parse(txtFirst.Text);
            double num2 = Double.Parse(txtSecond.Text);
            txtResult.Text = buildResultString("sum", num1, num2, num1 + num2);
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            double num1 = Double.Parse(txtFirst.Text);
            double num2 = Double.Parse(txtSecond.Text);
            txtResult.Text = buildResultString("difference", num1, num2, num1 - num2);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double num1 = Double.Parse(txtFirst.Text);
            double num2 = Double.Parse(txtSecond.Text);
            txtResult.Text = buildResultString("product", num1, num2, num1 * num2);
        }

        private void btnQuot_Click(object sender, EventArgs e)
        {
            double num1 = Double.Parse(txtFirst.Text);
            double num2 = Double.Parse(txtSecond.Text);
            txtResult.Text = buildResultString("quotient", num1, num2, num1 / num2);
        }

        private String buildResultString(String op, double lhs, double rhs, double result)
        {
            return "The " + op + " of " + lhs + " and " + rhs + " is " + result;
        }
    }
}
