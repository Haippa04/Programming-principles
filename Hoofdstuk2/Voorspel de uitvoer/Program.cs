namespace Voorspel_de_uitvoer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal = 5;
            getal++;
            getal += 3;
            getal /= 2;
            //Console.WriteLine(getal);

            int a = 5;
            int b = a++;
            //Console.WriteLine($"{a} {b}");

            Console.WriteLine(9 / 2);
            Console.WriteLine(9 / 2.0);
            Console.WriteLine(1.0 * 7 / 2);
            Console.WriteLine(1.0 * (7 / 2));
            Console.WriteLine(-7 / 2);
            Console.WriteLine(17 % 5 * 2);
        }
    }
}
