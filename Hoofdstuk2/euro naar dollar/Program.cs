namespace euro_naar_dollar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bedragInEuro = 78.65;
            double conversie = (bedragInEuro * 1.03);

            Console.WriteLine($"{bedragInEuro} EUR is gelijk aan {conversie} USD.");
        }
    }
}
