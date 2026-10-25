namespace prijskaartje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int artikelnummer = 4217;
            string omschrijving = "Jonge kaas";
            double gewicht = 0.45;          // in kg
            double prijsPerKilo = 27.44;
            double teBetalen = 12.35;


            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("******************************");
            Console.WriteLine($" Artikel:        {artikelnummer:000000}\n Omschrijving:   {omschrijving}\n Gewicht:        {gewicht:0.000}\n Prijs per kg:   {prijsPerKilo:C}\n Te betalen:     {teBetalen:C}\n");
            Console.WriteLine("******************************");
        }
    }
}
