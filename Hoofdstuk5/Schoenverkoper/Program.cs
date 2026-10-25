namespace Schoenverkoper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoeveel paar schoenen koopt de klant?");
            int paarSchoenen = int.Parse(Console.ReadLine());

            Console.WriteLine("Tot en met hoeveel paar geldt het volle tarief? (3 tot en met 10)");
            int volleTarief = int.Parse(Console.ReadLine());

            if (volleTarief < 3 || volleTarief > 10)
            {
                volleTarief = 9;
            }

            int na9 = Math.Max(0, paarSchoenen - volleTarief);
            int totalePrijsVoor9 = Math.Min(paarSchoenen, volleTarief) * 20;
            int totalePrijsNa9 = na9 * 10;

            int totalePrijs = totalePrijsVoor9 + totalePrijsNa9;

            Console.WriteLine($"Dat kost {totalePrijs} euro.");

        }
    }
}
