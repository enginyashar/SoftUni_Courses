using System;

namespace P12_NL_Lab_04.SumofTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // x1 + x2 == n

            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int x1 = startNum; x1 <= endNum; x1++)
            {
                for (int x2 = startNum; x2 <= endNum; x2++)
                {
                    count++;
                    if (x1 + x2 == n)
                    {
                        Console.WriteLine($"Combination N:{count} ({x1} + {x2} = {n})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {n}");            
        }
    }
}