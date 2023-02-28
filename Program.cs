namespace H1_Intro_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                mm();
            }

        }

        static void mm()
        {
            Console.Write("Første tal : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Lorten : ");
            string l = Console.ReadLine();

            Console.Write("Anden tal : ");
            int b = int.Parse(Console.ReadLine());
        }
    }
}