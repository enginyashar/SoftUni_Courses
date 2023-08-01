using System;

namespace P12_NL_Lab_01.Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    Console.WriteLine($"{i:d2}:{j:d2}");
                }
            }
        }
    }
}
