namespace Feestkassa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Frietjes?");
            int hoeveelheid_frietjes = int.Parse(Console.ReadLine());
            int tussenprijs_1 = hoeveelheid_frietjes * 20;
            Console.WriteLine($"Tussenprijs= {tussenprijs_1}");
            Console.WriteLine("Koninginnenhapje?");
            int hoeveelheid_hapje = int.Parse(Console.ReadLine());
            int tussenprijs_2 = hoeveelheid_hapje * 10;
            Console.WriteLine($"Tussenprijs= {tussenprijs_1} + {tussenprijs_2}");
            Console.WriteLine("Ijsjes");
            int hoeveelheid_ijsjes = int.Parse(Console.ReadLine());
            int tussenprijs_3 = hoeveelheid_ijsjes * 3;
            Console.WriteLine($"Tussenprijs= {tussenprijs_1} + {tussenprijs_2} + {tussenprijs_3}");
            Console.WriteLine("Dranken?");
            int hoeveelheid_drankje = int.Parse(Console.ReadLine());
            int tussenprijs_4 = hoeveelheid_drankje * 2;
            Console.WriteLine($"Tussenprijs= {tussenprijs_1} + {tussenprijs_2} + {tussenprijs_3} + {tussenprijs_4}");
            int totaal = tussenprijs_1 + tussenprijs_2 + tussenprijs_3 + tussenprijs_4;
            Console.WriteLine($"Het totaal te betalen bedrag is {totaal} EURO");

        }
    }
}
