using System;

namespace VegetableMarket
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int vegetableKg = int.Parse(Console.ReadLine());
            int fruitKg = int.Parse(Console.ReadLine());

            double vegetableTotal = (vegetablePrice * vegetableKg) / 1.94;
            double fruitTotal = (fruitPrice * fruitKg) / 1.94;

            Console.WriteLine("{0:F2}", vegetableTotal + fruitTotal);
        }
    }
}