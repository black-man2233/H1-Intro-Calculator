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
        /// <summary>
        /// 
        /// </summary>
        static void mm()
        {

            Console.Write("Første tal : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Lorten : ");
            string l = Console.ReadLine();

            Console.Write("Anden tal : ");
            int b = int.Parse(Console.ReadLine());

            MathModel mat = new MathModel(a, b, l);

            //
            // switchen gør vi kan have nogle af disse cases.
            // De tjekker så om hvilket input der blivet givet
            // Og køre koden for den case med det rigtige input

        }
    }
}