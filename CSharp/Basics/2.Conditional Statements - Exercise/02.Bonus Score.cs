using System;

namespace P027_CS_Exe_02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double total = 0;

            if (num <= 100)
            {
                total = 5;
            }
            else if (num <= 1000)
            {
                total = num * 0.2;
            }
            else
            {
                total = num * 0.1;
            }

            if (num % 2 == 0)
            {
                total += 1;
            }
            else if (num % 5 == 0)
            {
                total += 2;
            }
            Console.WriteLine(total);
            Console.WriteLine(total + num);
        }
    }
}
