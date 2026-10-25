namespace Stevens_busreis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();

            Console.WriteLine("hoeveel studenten gaan er mee?");
            double aantalStudenten = double.Parse(Console.ReadLine());

            Console.WriteLine("hoeveel plaatsen heeft een bus");
            double aantalPlaatsen = double.Parse(Console.ReadLine());

            Console.WriteLine("hoeveel kost een bus?");
            double kostPerBus = double.Parse(Console.ReadLine());

            double hoeveelheidBus = Math.Ceiling(aantalStudenten / aantalPlaatsen);
            double totalePrijsBus = hoeveelheidBus * kostPerBus;
            double kostPerStudent = Math.Round(totalePrijsBus / aantalStudenten);
            int rijNummer = randomGenerator.Next(0, 7);
          

            Console.WriteLine($"Er zijn {hoeveelheidBus} bussen nodig.");
            Console.WriteLine($"Elke student betaalt {kostPerStudent} euro.");
            Console.WriteLine($"Rij {rijNummer} mag als eerste instappen.");

        }
    }
}
