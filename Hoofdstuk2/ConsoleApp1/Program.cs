namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int nummer1 = -1 + (4 * 6);
            int nummer2 = (35 + 5) % 7;
            double nummer3 = 14 + (-4 * (6 / 11));
            double nummer4 = (2 + 15) / (6 * 1) - 7 % 2;

            Console.WriteLine($"-1 + 4 * 6 geeft ...{nummer1}");
            Console.WriteLine($"(35 + 5) % 7 geeft...{ nummer2}");
            Console.WriteLine($"14 + -4 * 6 / 11 geeft ...{nummer3}");
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 geeft ...{nummer4}");

        }
    }
}
