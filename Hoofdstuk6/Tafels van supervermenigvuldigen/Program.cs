namespace Tafels_van_supervermenigvuldigen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tot en met welk getal?");
            int getal = int.Parse(Console.ReadLine());
            int getal2 = 1;
            int getal1 = 1;

            for (int n = 1; n <= 10; n++)
            {
                for (int z = 1; z <= getal; z++)
                {
                    int tafel = getal1 * getal2;
                    Console.Write($"{getal1}x{getal2}={tafel},");
                    getal2++;
                    if (getal2 > getal)
                    {
                        getal2 = 1;
                    }
                }
                Console.WriteLine("");
                getal1++;
            }

        }
    }
}
