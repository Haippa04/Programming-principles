namespace gemiddelde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int september = 224;
            int oktober = 177;
            int november = 210;

            double gemiddelde = (september + oktober + november) / 3.0;
            Console.WriteLine($"je Sliep gemiddeld: {gemiddelde} uren per maand.");
        }
    }
}
