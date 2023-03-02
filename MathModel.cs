using System;

namespace H1_Intro_Calculator
{
    public class MathModel
    {
        /// <summary>
        /// take 2 int's as your inputs, the string is the math sign.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <param name="l">Math sign.</param>
        public MathModel(int a, int b, string l)
        {
            //Writes the result based on the given sign "l"
            switch (l)
            {
                case "+":
                    Console.WriteLine(Plus(a, b));
                    break;
                case "-":
                    Console.WriteLine(Minus(a, b));
                    break;
                case "*":
                    Console.WriteLine(Multiply(a, b));
                    break;
                case "/":
                    Console.WriteLine(Divide(a, b));
                    break;

                default:
                    break;
            }
        }
        /// <summary>
        /// Finds the sum from the 2 given inputs
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number</param>
        /// <returns>The sum of the 2 parameters.</returns>
        public double Plus(double a, double b) => a + b;
        public double Minus(double a, double b) => a - b;
        public double Divide(double a, double b) => a / b;
        public double Multiply(double a, double b) => a * b;

    }
}
