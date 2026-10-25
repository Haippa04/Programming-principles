using System.Security.Cryptography.X509Certificates;

namespace WelkDatatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aantal_studenten = 30;
            int wereldbevolking = 800000000;
            double prijs = 9.99;
            double temperatuur = 24;
            bool gehuwd = true;
            string eerste_letter = "K";
            int aantal_assen = 4;
            int postcode = 2560;


            Console.WriteLine($"aantal studenten: {aantal_studenten}, wereldbevolking: {wereldbevolking}, prijs, {prijs}, temperatuur: {temperatuur}, is persoon gehuwd?: {gehuwd}, eerste letter van naam: {eerste_letter}, aantal assen van de trein: {aantal_assen}, postcode: {postcode}");
        }
    }
}
