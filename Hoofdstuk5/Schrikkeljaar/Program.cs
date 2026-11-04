namespace Schrikkeljaar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool schrikkelJaar = false;
            Console.WriteLine("Geef een jaartal:");
            int jaartal = int.Parse(Console.ReadLine());
            if ((jaartal % 4 == 0) && (jaartal % 100 != 0) || (jaartal % 400 == 0))
            {
                schrikkelJaar = true;
            }

            else
            {
                schrikkelJaar = false;
            }
            string boodschap = schrikkelJaar == true ? $"{jaartal} is een schrikkeljaar" : $"{jaartal} is geen schrikkeljaar";
            Console.WriteLine(boodschap);

        }
    }
}
