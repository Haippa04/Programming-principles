namespace BMI
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
        }
    }
}
