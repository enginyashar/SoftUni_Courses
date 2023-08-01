using System;

namespace PB022_ME_CSA_04.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string classCar = string.Empty;
            string typeCar = (season == "Winter") ? "Jeep" : "Cabrio";

            if (budget <= 100)
            {
                classCar = "Economy class";
                budget *= (season == "Summer") ? 0.35 : 0.65;
            }
            else if (budget <= 500)
            {
                classCar = "Compact class";
                budget *= (season == "Summer") ? 0.45 : 0.8;
            }
            else
            {
                classCar = "Luxury class";
                typeCar = "Jeep";
                budget *= 0.9;
            }
            Console.WriteLine(classCar);
            Console.WriteLine($"{typeCar} - {budget:f2}");
        }
    }
}
