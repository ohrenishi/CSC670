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
        private double epsilon = 1e-14;

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
            Double? num1 = parseInputToDouble(txtFirst.Text);
            Double? num2 = parseInputToDouble(txtSecond.Text);
            if (num1 == null || num2 == null)
                return;
            txtResult.Text = buildResultString("sum", num1.Value, num2.Value, num1.Value + num2.Value);
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            Double? num1 = parseInputToDouble(txtFirst.Text);
            Double? num2 = parseInputToDouble(txtSecond.Text);
            if (num1 == null || num2 == null)
                return;
            txtResult.Text = buildResultString("difference", num1.Value, num2.Value, num1.Value - num2.Value);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Double? num1 = parseInputToDouble(txtFirst.Text);
            Double? num2 = parseInputToDouble(txtSecond.Text);
            if (num1 == null || num2 == null)
                return;
            txtResult.Text = buildResultString("product", num1.Value, num2.Value, num1.Value * num2.Value);
        }

        private void btnQuot_Click(object sender, EventArgs e)
        {
            Double? num1 = parseInputToDouble(txtFirst.Text);
            Double? num2 = parseInputToDouble(txtSecond.Text);
            if (num1 == null || num2 == null)
                return;
            if (Math.Abs(num2.Value) < epsilon)
            {
                MessageBox.Show("Division by zero is undefined; please enter a different number");
                return;
            }
            txtResult.Text = buildResultString("quotient", num1.Value, num2.Value, num1.Value / num2.Value);
        }

        private Double? parseInputToDouble(String value)
        {
            try
            {
                return Double.Parse(value);
            } catch (FormatException e)
            {
                MessageBox.Show("'" + value + "' is not a legitimate number; please enter a numeric value");
                return null;
            }
        }

        private String buildResultString(String op, double lhs, double rhs, double result)
        {
            return "The " + op + " of " + lhs + " and " + rhs + " is " + result;
        }
    }
}
