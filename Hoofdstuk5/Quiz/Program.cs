namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juist = 0;
            int fout = 0;
            int punten = 0;
            string volgende = "Druk op enter voor de volgende vraag";
            Console.WriteLine("Wie is de auteur van Zie Scherp Scherper?");
            Console.WriteLine("a.   Jef Bezos\nb.   Tim Dams\nc.   Joe Bro\nd.   Steve Jobs");
            string antwoord = Console.ReadLine();

            switch(antwoord){
                case "b":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Juist");
                    Console.ResetColor();
                    Console.WriteLine(volgende);
                    juist ++;
                    punten +=2;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("fout");
                    Console.ResetColor();
                    Console.WriteLine(volgende);
                    punten -= 1;
                    fout++;
                    break;
            }

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Wat is de hoofdstad van Australië?");
            Console.WriteLine("a.   Sydney\nb.   Melbourne\nc.   Canberra\nd.   Perth");
            antwoord = Console.ReadLine();

            switch (antwoord)
            {
                case "c":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Juist");
                    Console.ResetColor();
                    Console.WriteLine(volgende);
                    juist++;
                    punten += 2;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("fout");
                    Console.ResetColor();
                    Console.WriteLine(volgende);
                    punten -= 1;
                    fout++;
                    break;
            }

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("In welk jaar begon de Tweede Wereldoorlog in Europa?");
            Console.WriteLine("a.   1918\nb.   1945\nc.   1935\nd.   1939");
            antwoord = Console.ReadLine();

            switch (antwoord)
            {
                case "d":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Juist");
                    Console.ResetColor();
                    Console.WriteLine("Druk op enter om het te beëindigen");
                    juist++;
                    punten += 2;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("fout");
                    Console.ResetColor();
                    Console.WriteLine("Druk op enter om het te beëindigen");
                    punten -= 1;
                    fout++;
                    break;
            }

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"je had {juist} juist en {fout} fout. je eindscore is {punten}");

        }
    }
}
