using System;

namespace _10._Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int left = (n - 1) / 2;

            int stars = 1;

            if (n % 2 == 0)
            {
                stars++;
            }

            for (int i = 1; i <= (n - 1) / 2; i++)
            {
                Console.Write(new string('-', left));
                Console.Write("*");

                int mid = n - 2 * left - 2;

                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }

                Console.WriteLine(new string('-', left));
                left--;
            }

            for (int y = 1; y <= (n - 1) / 2; y++)
            {
                Console.Write(new string('-', left));
                Console.Write("*");

                int mid = n - 2 * left - 2;

                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }

                Console.WriteLine(new string('-', left));
                left++;
            }

            Console.Write(new string('-', left));
            Console.Write(new string('*', stars));
            Console.WriteLine(new string('-', left));
        }
    }
}
