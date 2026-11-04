namespace Stemwijzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sta je op voor 8u?");
            string antwoord = Console.ReadLine();
            if (antwoord == "j")
            {
                Console.WriteLine("Drink je koffie?");
                antwoord = Console.ReadLine();

                if (antwoord == "j")
                {
                    Console.WriteLine("Staat alles in je agenda?");
                    antwoord = Console.ReadLine();

                    if (antwoord == "j")
                    {
                        Console.WriteLine("Jouw stemprofiel: Planningspartij");
                    }

                    else
                    {
                        Console.WriteLine("Heb je vrienden?");
                        antwoord = Console.ReadLine();

                        string profiel = antwoord == "j" ? "Jouw stemprofiel: Gezeligheidspartij" : "Jouw stemprofiel: Blanco";
                        Console.WriteLine(profiel);
                    }
                }

                else
                {
                    Console.WriteLine("Jouw stemprofiel: Waterpartij");
                }
            }

            else
            {
                Console.WriteLine("Eet je elke dag friet?");
                antwoord = Console.ReadLine();

                if (antwoord == "j")
                {
                    Console.WriteLine("Jouw stemprofiel: Frietfront");
                }

                else
                {
                    Console.WriteLine("Heb je een huisdier?");
                    antwoord = Console.ReadLine();

                    if(antwoord == "j")
                    {
                        Console.WriteLine("Jouw stemprofiel: Knuffelpartij");
                    }

                    else
                    {
                        Console.WriteLine("Geloof je nog in sinterklaas?");
                        antwoord = Console.ReadLine();

                        string profiel = antwoord == "j" ? "Jouw stemprofiel: Sintunie" : "Jouw stemprofiel: Blanco";
                        Console.WriteLine(profiel);
                    }
                }
            }

        }
    }
}
