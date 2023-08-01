using System;

namespace P12_NL_Lab_03.Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            // x1 + x2 + x3 == n

            for (int x1 = 0; x1 <= n; x1++)
            {
                for (int x2 = 0; x2 <= n; x2++)
                {
                    for (int x3 = 0; x3 <= n; x3++)
                    {                     
                        if (x1 + x2 + x3 == n)
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
