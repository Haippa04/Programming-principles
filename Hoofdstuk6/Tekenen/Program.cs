namespace Tekenen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int breedte = 0;
            int hoogte = 0;
            int echte_h = hoogte - 2;
            do
            {
                Console.WriteLine("Breedte (2 tot en met 20)?");
                breedte = int.Parse(Console.ReadLine());
            } while (breedte > 20);

            do
            {
                Console.WriteLine("Hoogte (2 tot en met 20)?");
                hoogte = int.Parse(Console.ReadLine());
            } while (hoogte > 20);

            for (int i = 0; i < breedte; i++)
            {
                Console.Write("* ");
            }

            for (int i = 0; i< hoogte; i++)
            {
                Console.WriteLine("*");
            }
        }
    }
}
