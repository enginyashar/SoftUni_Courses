using System;

namespace P032_CS_Exe_07.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCard = int.Parse(Console.ReadLine());
            int prossecor = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double total = videoCard * 250;
            total += (total * 0.35 * prossecor) + (total * 0.1 * ram);

            if (videoCard > prossecor)
            {
                total *= 0.85;
            }

            if (budget >= total)
            {
                Console.WriteLine($"You have {budget - total:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {total - budget:f2} leva more!");
            }
            
        }
    }
}
