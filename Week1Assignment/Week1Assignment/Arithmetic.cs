using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Assignment
{
    class Arithmetic
    {
        public void math()
        {
            int number1; //declare first number
            int number2; //declare second number
            int sum;   //declare the sum
            int product; //declare the project
            int difference; //declare the difference
            int quotient; //declare the quotient

            Console.WriteLine("Please enter your first integer: "); //prompt user
            number1 = Convert.ToInt32(Console.ReadLine()); // read first number

            Console.WriteLine("Please enter your second integer: "); //prompt user
            number2 = Convert.ToInt32(Console.ReadLine()); // read second number



            sum = number1 + number2; //add numbers 

            Console.WriteLine("The sum is {0}", sum); //display sum



            product = number1 * number2; //multiply numbers

            Console.WriteLine("The product is {0}", product); //display product


            difference = number1 - number2; //subtract numbers

            Console.WriteLine("The differnece is {0}", difference); //display difference



            quotient = number1 / number2; //divide numbers

            Console.WriteLine("The quotient is {0}", quotient); //display quotient


        }
    }
}
