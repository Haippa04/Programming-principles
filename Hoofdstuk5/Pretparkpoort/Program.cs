using System.Reflection;

namespace Pretparkpoort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hoe groot ben je, in cm?");
            int lengte = int.Parse(Console.ReadLine());


            if (lengte < 100) 
            { 
                Console.WriteLine("Sorry, je bent te klein om binnen te mogen.");
            }
            else if (lengte < 120) 
            { 
                Console.WriteLine("Je mag binnen, maar enkel met een begeleider.");
            }
            else if (lengte <= 140) 
            { 
                Console.WriteLine("Je mag binnen, maar enkel op de kinderattracties.");
            }
            else
            { 
                Console.WriteLine("Je mag op alle attracties.");
            }

        }
    }
}
