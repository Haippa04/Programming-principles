namespace Dertien_in_een_dozijn
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int DOOS_GROOTTE = 9;
            int aantalEieren = 174;
            int rest = aantalEieren % DOOS_GROOTTE;
            int aantal_dozen = aantalEieren / DOOS_GROOTTE;

            Console.WriteLine($"{aantalEieren} eieren passen in {aantal_dozen} dozen van {DOOS_GROOTTE}. Je houdt {rest} eieren over.");
        }
    }
}
