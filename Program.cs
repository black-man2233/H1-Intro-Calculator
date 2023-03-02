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
                try
                {
                    //Giving user the option to write any number
                    //Store the written nummber
                    Console.Write("Første tal : ");
                    int a = int.Parse(Console.ReadLine());

                    //Giving user the option to write Math equations (+,-,/,*)
                    Console.Write("Lorten : ");
                    string l = Console.ReadLine();

                    Console.Write("Anden tal : ");
                    int b = int.Parse(Console.ReadLine());

                    MathModel mat = new MathModel(a, b, l);
                }
                catch
                {
                    Console.WriteLine("Der sket en fejl, Prøv igen");
                }


                Console.WriteLine();
                Console.WriteLine("------------------------------");


            }
        }
    }
}