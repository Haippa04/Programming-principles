namespace Op_de_poef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een bedrag in: ");
            double input1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"De poef staat op {input1} euro.");
            Console.WriteLine("Voer een bedrag in: ");
            double input2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"De poef staat op {input1+input2} euro.");
            Console.WriteLine("Voer een bedrag in: ");
            double input3 = double.Parse(Console.ReadLine());
            Console.WriteLine($"De poef staat op {input1 + input2 + input3} euro.");
            Console.WriteLine("Voer een bedrag in: ");
            double input4 = double.Parse(Console.ReadLine());
            Console.WriteLine($"De poef staat op {input1 + input2 + input3 + input4} euro.");
            Console.WriteLine("Voer een bedrag in: ");
            double input5 = double.Parse(Console.ReadLine());
            Console.WriteLine($"De poef staat op {input1 + input2 + input3 + input4 + input5} euro.");

            double totaal = input1 + input2 + input3 + input4 + input5;
            double afbetaling = Math.Round(totaal / 10);
            Console.WriteLine("********************************");
            Console.WriteLine($"Het totaal van de poef is {totaal} euro en zal {afbetaling} weken duren om volledig afbetaald te worden.");
        }
    }
}
