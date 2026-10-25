namespace Graden_omzetten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int celsius = 28;
            double Farenheit = celsius * 9 / 5 + 32;

            Console.WriteLine($"{celsius} graden Celsius is {Farenheit} graden Fahrenheit.");
        }
    }
}
