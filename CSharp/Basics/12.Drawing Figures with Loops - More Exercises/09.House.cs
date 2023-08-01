using System;

namespace _09.House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int cnt = 1;

            if (n % 2 == 0)
            {
                cnt++;
            }

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                int dashCount = (n - cnt) / 2;
                Console.WriteLine(new string('-', dashCount) + new string('*', cnt) + new string('-', dashCount));
                cnt += 2;
            }

            for (int j = 0; j < n / 2; j++)
            {
                Console.WriteLine('|' + new string('*', n - 2) + '|');
            }
        }
    }
}
