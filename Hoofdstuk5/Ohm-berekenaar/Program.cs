namespace Ohm_berekenaar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat wil je berekenen? spanning, weerstand of stroomsterkte?");
            string keuzen = Console.ReadLine();
            if (keuzen == "stroomsterkte")
            {
                Console.WriteLine("Geef me dan de spanning:");
                double spanning = double.Parse(Console.ReadLine());
                Console.WriteLine("Geef me dan de weerstand:");
                double weerstand = double.Parse(Console.ReadLine());

                if (weerstand == 0)
                {
                    Console.WriteLine("KORTSLUITING!!!!");
                }

                else
                {
                    double berekening = Math.Round((spanning / weerstand), 2);
                    Console.WriteLine($"De stroomsterkte bedraagt dan {berekening} ampère");
                }
            }

            else if (keuzen == "weerstand")
            {
                Console.WriteLine("Geef me dan de spanning:");
                double spanning = double.Parse(Console.ReadLine());
                Console.WriteLine("Geef me dan de stroomsterkte:");
                double stroomsterkte = double.Parse(Console.ReadLine());

                
                if (stroomsterkte == 0)
                {
                    Console.WriteLine("error");
                }

                else
                {
                    double berekening = Math.Round((spanning / stroomsterkte), 2);
                    Console.WriteLine($"De weerstand bedraagt dan {berekening} ohm");
                }

            }


            else if (keuzen == "spanning")
            {
                Console.WriteLine("Geef me dan de weerstand:");
                double weerstand = double.Parse(Console.ReadLine());
                Console.WriteLine("Geef me dan de stroomsterkte:");
                double stroomsterkte = double.Parse(Console.ReadLine());

                double berekening = Math.Round((weerstand * stroomsterkte), 2);
                Console.WriteLine($"De spanning bedraagt dan {berekening} volt");
            }


            else
            {
                Console.WriteLine("error");

            }
        }
    }
}
