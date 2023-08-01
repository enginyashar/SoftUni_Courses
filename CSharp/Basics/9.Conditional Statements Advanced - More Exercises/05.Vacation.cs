using System;

namespace PB023_ME_CSA_05.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = string.Empty;
            string location = (season == "Winter") ? "Morocco" : "Alaska";

            if (budget <= 1000)
            {
                place = "Camp";
                budget *= (season == "Summer") ? 0.65 : 0.45;
            }
            else if (budget <= 3000)
            {
                place = "Hut";
                budget *= (season == "Summer") ? 0.8 : 0.6;
            }
            else
            {
                place = "Hotel";
                budget *= 0.9;
            }
            Console.WriteLine($"{location} - {place} - {budget:f2}");
        }
    }
}
