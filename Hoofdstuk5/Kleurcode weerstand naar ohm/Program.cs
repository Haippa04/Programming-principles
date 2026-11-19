namespace Kleurcode_weerstand_naar_ohm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef de 3 ringkleuren na elkaar, telkens gevolgd door enter:");
            string ring1 = Console.ReadLine();
            string ring2 = Console.ReadLine();
            string ring3 = Console.ReadLine();
            int cijfer1 = 0;
            int cijfer2 = 0;
            int vermenigvuldiging = 0;

            switch (ring1)
            {
                case "zwart":
                    cijfer1 = 0;
                    break;

                case "bruin":
                    cijfer1 = 1;
                    break;

                case "rood":
                    cijfer1 = 2;
                    break;

                case "oranje":
                    cijfer1 = 3;
                    break;
            }


            switch (ring2)
            {
                case "zwart":
                    cijfer2 = 0;
                    break;

                case "bruin":
                    cijfer2 = 1;
                    break;

                case "rood":
                    cijfer2 = 2;
                    break;
            }

            switch (ring3)
            {

                case "zwart":
                    vermenigvuldiging = 1;
                    break;

                case "bruin":
                    vermenigvuldiging = 10;
                    break;

                case "rood":
                    vermenigvuldiging = 100;
                    break;
            }


            int resultaat = (((cijfer1 * 10) + cijfer2) * vermenigvuldiging);
            Console.WriteLine($"Deze weerstand heeft een waarde van {resultaat} ohm");
        }
    }
}
