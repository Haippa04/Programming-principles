namespace KillDeathRatio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int kills = 50;
            int deaths = 9;

            double killdeathavg = ((kills/1.0) / (deaths/1.0));

            Console.WriteLine($"your k/d is: {killdeathavg/1.0}");
        }
    }
}
