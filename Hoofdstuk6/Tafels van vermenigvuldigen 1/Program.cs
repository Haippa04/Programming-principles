namespace Tafels_van_vermenigvuldigen_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Van welk getal wil je de tafel?");
            int getal = int.Parse(Console.ReadLine());
            for (int n = 1; n<=10; n++)
            {
                int tafel = n * getal;
                Console.WriteLine($"{n} x {getal} = {tafel}");
            }
        }
    }
}
