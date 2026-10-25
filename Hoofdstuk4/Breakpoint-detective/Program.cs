namespace Breakpoint_detective
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempGisteren = 20;
            int tempVandaag = 25;
            int som = tempGisteren + tempVandaag;
            double gemiddelde = som / (double) 2;
            double afgerond = Math.Round(gemiddelde, 1);
            Console.WriteLine($"Gemiddelde temperatuur: {afgerond} graden");
        }
    }
}
