using System;

namespace PB019_ME_CSA_01.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int fans = int.Parse(Console.ReadLine());

            double tickets = 0;

            if (fans <= 4)
            {
                budget *= 0.25;
            }
            else if (fans <= 9)
            {
                budget *= 0.4;
            }
            else if (fans <= 24)
            {
                budget *= 0.5;
            }
            else if (fans <= 49)
            {
                budget *= 0.6;
            }
            else
            {
                budget *= 0.75;
            }

            if (category == "VIP")
            {
                tickets = fans * 499.99;
            }
            else
            {
                tickets = fans * 249.99;
            }

            if (budget >= tickets)
            {
                Console.WriteLine($"Yes! You have {budget - tickets:f2} leva left."); 
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - tickets):f2} leva.");
            }
        }
    }
}
