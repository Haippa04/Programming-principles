namespace Hoofdstuk4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef de lengte:");
            int inputLengte = int.Parse(Console.ReadLine());
            Console.WriteLine("geef de breedte:");
            int inputBreedte = int.Parse(Console.ReadLine());
            Console.WriteLine("geef de hoogte:");
            int inputHoogte = int.Parse(Console.ReadLine());

            int inhoud = inputBreedte * inputLengte * inputHoogte;

            int oppervlakte = 2 * (inputBreedte * inputLengte + inputBreedte * inputHoogte + inputLengte * inputHoogte);

            Console.WriteLine($"inhoud : {inhoud}");
            Console.WriteLine($"oppervlakte: {oppervlakte}");
            Console.WriteLine($"");

        }
    }
}
