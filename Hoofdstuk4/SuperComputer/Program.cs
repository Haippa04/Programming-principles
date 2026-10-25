namespace SuperComputer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef getal 1:");
            double inputGetal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("geef getal 2:");
            double inputGetal2 = double.Parse(Console.ReadLine());
            Console.WriteLine("geef getal 3:");
            double inputGetal3 = double.Parse(Console.ReadLine());

            double gemiddelde = (inputGetal1 + inputGetal2 + inputGetal3)/3;

            Console.WriteLine($"gemiddelde : {gemiddelde}");

        }
    }
}
