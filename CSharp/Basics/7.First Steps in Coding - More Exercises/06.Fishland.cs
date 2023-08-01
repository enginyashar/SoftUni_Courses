using System;

namespace Fishland
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            double mackerelPriceKg = double.Parse(Console.ReadLine());
            double spratPriceKg = double.Parse(Console.ReadLine());

            double bonitoKg = double.Parse(Console.ReadLine());
            double scadKg = double.Parse(Console.ReadLine());
            int musselKg = int.Parse(Console.ReadLine());

            double total = (bonitoKg * mackerelPriceKg * 1.6) + (scadKg * spratPriceKg * 1.8) + (musselKg * 7.5);

            Console.WriteLine("{0:F2}", total);
        }
    }
}