using System;

namespace H1_Intro_Calculator
{
    public class MathModel
    {
        /// <summary>
        /// den suttre
        /// for meget 
        /// pik
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b">  </param>
        /// <param name="l"></param>
        public MathModel(int a, int b, string l)
        {
            switch (l)
            {
                case "+":
                    Console.WriteLine(this.Plus(a, b));
                    break;
                case "-":
                    Console.WriteLine(this.Minus(a, b));
                    break;
                case "*":
                    Console.WriteLine(this.Multiply(a, b));
                    break;
                case "/":
                    Console.WriteLine(this.Divide(a, b));
                    break;

                default:
                    break;
            }
        }

        public double Plus(double a, double b) => a + b;
        public double Minus(double a, double b) => a - b;
        public double Divide(double a, double b) => a / b;
        public double Multiply(double a, double b) => a * b;

    }
}
