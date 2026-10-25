namespace Wisselgeld_in_centen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welk bedrag moet je teruggeven?");
            double bedrag = double.Parse (Console.ReadLine());
            int bedrag_cent = (int) (bedrag *  100);
            Console.WriteLine($"Dat is dan {bedrag_cent} cent.");
            double bedrag_cent_200 = bedrag_cent / 200;
            Console.WriteLine($"{bedrag_cent_200} X 2 euro");
            double nieuwBedrag_1 = bedrag_cent % 200;


            double bedragCent100 = (int) (nieuwBedrag_1 / 100);
            Console.WriteLine($"{bedragCent100} X 1 euro");
            double nieuwBedrag_2 = nieuwBedrag_1 % 100;

            double bedragCent50 = (int) (nieuwBedrag_2 / 50);
            Console.WriteLine($"{bedragCent50} X 50 cent");
            double nieuwBedrag_3 = nieuwBedrag_2 % 50;
            
            double bedragCent20 = (int)(nieuwBedrag_3 / 20);
            Console.WriteLine($"{bedragCent20} X 20 cent");
            double nieuwBedrag_4 = nieuwBedrag_3 % 20;

            double bedragCent10 = (int)(nieuwBedrag_4 / 10);
            Console.WriteLine($"{bedragCent10} X 10 cent");
            double nieuwBedrag_5 = nieuwBedrag_4 % 10;

            double bedragCent5 = (int)(nieuwBedrag_5 / 5);
            Console.WriteLine($"{bedragCent5} X 5 cent");
            double nieuwBedrag_6 = nieuwBedrag_5 % 5;

            double bedragCent2 = (int)(nieuwBedrag_6 / 2);
            Console.WriteLine($"{bedragCent2} X 2 cent");
            double nieuwBedrag_7 = nieuwBedrag_6 % 2;

            double bedragCent1 = (int)(nieuwBedrag_7 / 1);
            Console.WriteLine($"{bedragCent1} X 1 cent");


        }
    }
}
