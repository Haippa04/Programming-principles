namespace SterrenpatronenD3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal = 10;
            int aantal = 10;
            int dots = 5;
            for (int z = 1; z <= aantal; z+=2)
            {
                for(int n = 1; n<= dots; n++)
                {
                    Console.Write(" ");
                }
                for (int n = 1; n <= z; n+=1)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                getal--;
                dots--;
            }
        }
    }
}
