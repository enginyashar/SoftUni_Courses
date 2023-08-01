using System;

namespace PB025_ME_CSA_07.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            double tax = 0;
            string sport = string.Empty;

            if (group == "girls" || group == "boys")
            {
                if (season == "Winter")
                {
                    tax = 9.6;
                    sport = (group == "girls") ? "Gymnastics" : "Judo";
                }
                else if (season == "Spring")
                {
                    tax = 7.2;
                    sport =  (group == "girls") ? "Athletics" : "Tennis";                    
                }
                else
                {
                    tax = 15;
                    sport = (group == "girls") ? "Volleyball" : "Football";
                }
            }
            else
            {
                if (season == "Winter")
                {
                    tax = 10;
                    sport = "Ski";
                }
                else if (season == "Spring")
                {
                    tax = 9.5;
                    sport = "Cycling";
                }
                else
                {
                    tax = 20;
                    sport = "Swimming";
                }
            }
            tax *= (nights * students);

            if (students >= 50)
            {
                tax *= 0.5;
            }
            else if (students >= 20)
            {
                tax *= 0.85;
            }
            else if (students >= 10)
            {
                tax *= 0.95;
            }

            Console.WriteLine($"{sport} {tax:f2} lv.");
        }
    }
}
