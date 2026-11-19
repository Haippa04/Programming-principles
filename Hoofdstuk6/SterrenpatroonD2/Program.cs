namespace SterrenpatroonD2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal = 5;
            int aantal = 5;
            for (int z = 1; z <= aantal; z++)
            {
                for (int n = 1; n <= getal; n++)
                {
                    Console.Write(" ");
                }
                for (int n = 1; n <= z; n++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine("");
                getal--;
            }
        }
    }
}
