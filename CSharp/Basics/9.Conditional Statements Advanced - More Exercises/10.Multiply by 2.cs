using System;

namespace PB028_ME_CSA_10.MultiplyBy2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 0;

            while (num >= 0)
            {
                num = double.Parse(Console.ReadLine());

                if (num >= 0)
                {
                    Console.WriteLine($"Result: {num * 2 :f2}");
                }
            }

            if (num < 0)
            {
                Console.WriteLine("Negative number!");
            }
        }
    }
}
