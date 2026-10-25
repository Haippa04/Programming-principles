namespace Stevens_busreis_stevens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoeveel studenten gaan er mee?");
            int studenten = int.Parse(Console.ReadLine());
            Console.WriteLine("Hoeveel plaatsen heeft een bus?");
            int perBus = int.Parse(Console.ReadLine());
            Console.WriteLine("Hoeveel kost een bus?");
            double busPrijs = double.Parse(Console.ReadLine());

            double aantalBussen = Math.Ceiling((double)studenten / (double)perBus);
            double prijsPerStudent = Math.Round((aantalBussen * busPrijs / studenten),MidpointRounding.AwayFromZero);

            Random dobbelsteen = new Random();
            int rij = dobbelsteen.Next(1, 7);

            Console.WriteLine($"Er zijn {aantalBussen} bussen nodig.");
            Console.WriteLine($"Elke student betaalt {prijsPerStudent} euro");
            Console.WriteLine($"Rij {rij} mag als eerste instappen.");
        }
    }
}
