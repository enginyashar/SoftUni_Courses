using System;

namespace P06_CSA_Exe_05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string country = string.Empty;
            string place = (season == "summer") ? "Camp" : "Hotel";


            if (budget <= 100)
            {
                country = "Bulgaria";

                if (season == "summer")
                {
                    budget *= 0.3;
                }
                else
                {
                    budget *= 0.7;
                }
            }
            else if (budget <= 1000)
            {
                country = "Balkans";

                if (season == "summer")
                {
                    budget *= 0.4;
                }
                else
                {
                    budget *= 0.8;
                }
            }
            else
            {
                country = "Europe";
                budget *= 0.9;
                place = "Hotel";
            }

            Console.WriteLine($"Somewhere in {country}");
            Console.WriteLine($"{place} - {budget:f2}");
        }
    }
}
