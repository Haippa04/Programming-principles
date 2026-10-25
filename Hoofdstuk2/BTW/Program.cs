namespace BTW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // double prijs = 20;
            // const double BTW = 21.0;

            int prijs = 20;
            const int BTW = 21;

            double afgetrokken_prijs = (prijs / 100) * BTW;
            double totale_prijs = prijs + afgetrokken_prijs;

           // Console.WriteLine($"Prijs {prijs} euro zonder btw. Met BTW: {totale_prijs} euro.");
            Console.WriteLine(prijs + prijs / 100 * BTW);
            Console.WriteLine(prijs + prijs * BTW / 100);
        }
    }
}
