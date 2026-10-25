namespace Stevens_ticketprijs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoe oud ben je?");
            int leeftijd = int.Parse(Console.ReadLine());

            const double NORMALE_PRIJS = 20;
            double prijs = NORMALE_PRIJS;
            if (leeftijd < 12)
            {
                prijs = 0;
            }
            else if (leeftijd < 25)
            {
                prijs = 15;
            }
            else if (leeftijd >= 65)
            {
                prijs = 12;
            }
            double korting = NORMALE_PRIJS - prijs;

            Console.WriteLine($"Je ticket kost {prijs} euro. Je krijgt {korting} euro korting.");
        }
    }
}
