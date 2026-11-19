namespace Sterrenpatronen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal = 5;
            for (int z = 1; z <= 5; z++)
            {
                for (int n = 1; n <= getal; n++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
                getal--;
            }
        }
    }
}
