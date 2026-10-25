namespace Orakeltje_van_Delphi__part_deux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            Console.WriteLine("Ben je een man of een vrouw (m/v)?");
            string gender = Console.ReadLine();
            if ((gender == "m") ||(gender == "v"))
            {
                Console.WriteLine("hoe oud ben je?");
                int leeftijd = int.Parse(Console.ReadLine());
                if (gender == "m")
                {
                    if (leeftijd >= 115)
                    {
                        Console.WriteLine($"Het orakel zwijgt en kijkt je medelijdend aan.");
                    }

                    else { 
                    int voorspellingM = 120 - leeftijd;
                    int randomM = randomGenerator.Next(6, voorspellingM);
                    Console.WriteLine($"je zal nog {randomM} jaar leven.");
                    }
                }
                else if(gender == "v")
                {
                    if (leeftijd >= 145)
                    {
                        Console.WriteLine($"Het orakel zwijgt en kijkt je medelijdend aan.");
                    }

                    else { 
                    int voorspellingV = 150 - leeftijd;
                    int randomV = randomGenerator.Next(6, voorspellingV);
                    Console.WriteLine($"je zal nog {randomV} jaar leven.");
                    }
                }
            }

            else
            {
                Console.WriteLine("Het orakel begrijpt je antwoord niet.");
            }
        }
    }
}
