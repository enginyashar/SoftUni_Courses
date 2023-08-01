using System;
namespace NumbersNto1
{
    class ConsoleApp
    {
        static void Main()
        {
            string n = Console.ReadLine();

            for (int i = 0; i < n.Length; i++)
            {
                char letter = n[i];
                Console.WriteLine(letter);
            }
        }
    }
}