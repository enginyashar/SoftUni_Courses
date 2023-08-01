using System;

namespace P049_CSA_Exe_04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());

            double total = 0;

            if (season == "Spring")
            {
                total = 3000;
            }
            else if (season == "Winter")
            {
                total = 2600;
            }
            else
            {
                total = 4200;
            }

            if (fishers <= 6)
            {
                total *= 0.9;
            }
            else if (fishers <= 11)
            {
                total *= 0.85;
            }
            else
            {
                total *= 0.75;
            }

            if (fishers % 2 == 0 && season != "Autumn")
            {
                total *= 0.95;
            }

            if (budget >= total)
            {
                Console.WriteLine($"Yes! You have {budget - total:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {total - budget:f2} leva.");
            }
        }
    }
}