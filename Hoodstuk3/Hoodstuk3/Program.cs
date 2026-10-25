using System.Globalization;

namespace Hoodstuk3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("voer een naam in:");
            string naam = Console.ReadLine();
            Console.WriteLine("geef een zelfstandig naamwoord:");
            String zelfstandig = Console.ReadLine();
            Console.WriteLine("geef een adjectief");
            string adjectief = Console.ReadLine();
            Console.WriteLine("geef een werkwoord");
            string werkwoord = Console.ReadLine();

            Console.WriteLine($"Op een dag ging {naam} naar de AP Hogeschool. Hij zag daar een groene {zelfstandig} en vond dat zo {adjectief} dat hij begon te {werkwoord}.");

        }
    }
}
