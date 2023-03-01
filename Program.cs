namespace H1_Intro_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($@"Calcalutor ");
            Console.WriteLine($@"--------------");

            while (true)
            {
                mm();

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("--------------------------------");
                }

            }

        }

        static void mm()
        {
            MathModel mat = new MathModel();

            Console.Write("Første tal : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Lorten : ");
            string l = Console.ReadLine();

            Console.Write("Anden tal : ");
            int b = int.Parse(Console.ReadLine());

            switch (l)
            {
                case "+":
                    Console.WriteLine(mat.Plus(a, b));
                    break;
                case "-":
                    Console.WriteLine(mat.Minus(a, b));
                    break;
                case "*":
                    Console.WriteLine(mat.Multiply(a, b));
                    break;
                case "/":
                    Console.WriteLine(mat.Divide(a, b));
                    break;

                default:
                    break;
            }
        }
    }
}