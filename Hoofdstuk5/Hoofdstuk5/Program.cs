namespace Hoofdstuk5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int randomGetal1 = randomGenerator.Next(1, 7);
            Console.WriteLine("Welk getal heb ik geworpen?");
            int gok = int.Parse(Console.ReadLine());
            if (gok == randomGetal1)
            {
                int randomGetal2 = randomGenerator.Next(1, 7);
                Console.WriteLine("Welk getal heb ik nu geworpen?");
                int gok2 = int.Parse(Console.ReadLine());
                if (gok2 == randomGetal2)
                {
                    int randomGetal3 = randomGenerator.Next(1, 7);
                    Console.WriteLine("Welk getal heb ik nu geworpen?");
                    int gok3 = int.Parse(Console.ReadLine());

                    if (gok3 == randomGetal3)
                    {
                        Console.WriteLine("proficiat!");
                    }
                    else
                    {
                        Console.WriteLine($"you lose ik wierp {randomGetal3}");
                    }
                }
                else
                {
                    Console.WriteLine($"you lose ik wierp {randomGetal2}");
                }

            }
            else
            {
                Console.WriteLine($"you lose ik wierp {randomGetal1}");
            }
        }   
    }
}
