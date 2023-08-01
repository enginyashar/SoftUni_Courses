using System;

namespace HousePainting
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double greenPaint = (2 * (x * x) - 1.2 * 2 + 2 * (x * y - 1.5 * 1.5)) / 3.4;
            double redPaint = (2 * x * y + 2 * x * h / 2) / 4.3;

            Console.WriteLine("{0:F2}", greenPaint);
            Console.WriteLine("{0:F2}", redPaint);
        }
    }
}