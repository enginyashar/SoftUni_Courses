using System;

namespace P029_CS_Exe_04.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceExcursion = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());

            int toys = puzzle + doll + bear + minion + truck;
            double total = puzzle * 2.6 + doll * 3.0 + bear * 4.1 + minion * 8.2 + truck * 2.0;

            if (toys >= 50)
            {
                total *= 0.75;
            }
            total *= 0.9;

            if (total >= priceExcursion)
            {
                Console.WriteLine($"Yes! {total - priceExcursion:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceExcursion - total:f2} lv needed.");
            }            
        }
    }
}
