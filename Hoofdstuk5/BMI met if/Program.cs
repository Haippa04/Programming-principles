namespace BMI_met_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is uw lengte in cm?");
            double inputLengte = double.Parse(Console.ReadLine());
            Console.WriteLine("Wat is uw gewicht in kg?");
            double inputGewicht = double.Parse(Console.ReadLine());
            double meter = inputLengte / 100;
            double bmi = inputGewicht / (meter * meter);
            Console.WriteLine($"Een persoon met een lengte van {meter} m en een gewicht van {inputGewicht} kg heeft een BMI van {Math.Round(bmi, 2)}.");

            if (bmi < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ondergewicht");
                Console.ResetColor();
            }
            else if (bmi < 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Normaal gewicht");
                Console.ResetColor();
            }
            else if (bmi < 30)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Overgewicht");
                Console.ResetColor();
            }
            else if (bmi < 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zwaarlijvigheid");
                Console.ResetColor();
            }
            else if(bmi >= 40 )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ernstige zwaarlijvigheid");
                Console.ResetColor();
            }


        }
    }
}
