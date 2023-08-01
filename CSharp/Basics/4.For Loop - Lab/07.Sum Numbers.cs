using System;
namespace NumbersNto1
{
    class ConsoleApp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                sum += nums;
            }
            Console.WriteLine(sum);
        }
    }
}