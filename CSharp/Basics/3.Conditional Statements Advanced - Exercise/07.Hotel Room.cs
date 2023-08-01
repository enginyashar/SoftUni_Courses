using System;

namespace HotelRoom
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double totalPriceStudio = 0.0;
            double totalPriceApartment = 0.0;

            if (month == "May" || month == "October")
            {
                if (nights <= 7)
                {
                    totalPriceStudio = nights * 50;
                    totalPriceApartment = nights * 65;
                }
                else if (nights > 7 && nights <= 14)
                {
                    totalPriceStudio = nights * 50 * 0.95;
                    totalPriceApartment = nights * 65;
                }
                else if (nights > 14)
                {
                    totalPriceStudio = nights * 50 * 0.7;
                    totalPriceApartment = nights * 65 * 0.9;
                }

            }
            else if (month == "June" || month == "September")
            {
                if (nights <= 14)
                {
                    totalPriceStudio = nights * 75.2;
                    totalPriceApartment = nights * 68.7;
                }
                else if (nights > 14)
                {
                    totalPriceStudio = nights * 75.2 * 0.8;
                    totalPriceApartment = nights * 68.7 * 0.9;
                }
            }
            else if (month == "July" || month == "August")
            {
                if (nights <= 14)
                {
                    totalPriceStudio = nights * 76;
                    totalPriceApartment = nights * 77;
                }
                else if (nights > 14)
                {
                    totalPriceStudio = nights * 76;
                    totalPriceApartment = nights * 77 * 0.9;
                }
            }

            Console.WriteLine($"Apartment: {totalPriceApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
        }
    }
}