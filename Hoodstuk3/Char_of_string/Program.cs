namespace Char_of_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter1 = 'A';
            char letter2 = 'B';

            Console.WriteLine('A' + 'B');
            Console.WriteLine("A" + "B");
            Console.WriteLine('1' + 1);
            Console.WriteLine('a' - 'A');
            Console.WriteLine("1" + 1 + 1);
            Console.WriteLine(1 + 1 + "1");
            Console.WriteLine($"{letter1}{letter2}");
        }
    }
}
