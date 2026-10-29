using System.Runtime.Serialization;

namespace Euler_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int som = 0;
            for (int n = 0; n<=10; n++)
            {
                int deelDoor3 = n % 3;
                int deelDoor5 = n % 5;
                if ((deelDoor3 == 0) || (deelDoor5 == 0))
                {
                    

                }
                som += n;
                Console.WriteLine(som);
            }
        }
    }
}
