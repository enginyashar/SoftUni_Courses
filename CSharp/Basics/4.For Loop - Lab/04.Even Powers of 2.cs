using System;
namespace NumbersNto1
{
    class ConsoleApp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int num = 1;

            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(num);
                num = num * 2 * 2;
            }
        }
    }
}