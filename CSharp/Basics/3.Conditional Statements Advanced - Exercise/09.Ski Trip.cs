using System;

namespace SkiTrip
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            int stayDays = int.Parse(Console.ReadLine());
            string room = Console.ReadLine().ToLower();
            string review = Console.ReadLine().ToLower();


            int nights = stayDays - 1;
            double roomForOnePerson = nights * 18;
            double apartment = nights * 25;
            double presidentApartment = nights * 35;

            double result = roomForOnePerson;

            if (nights < 10)
            {
                if (room == "apartment")
                {
                    result = apartment * 0.7;
                }
                else if (room == "president apartment")
                {
                    result = presidentApartment * 0.9;
                }
            }
            else if (nights >= 10 && nights <= 15)
            {
                if (room == "apartment")
                {
                    result = apartment * 0.65;
                }
                else if (room == "president apartment")
                {
                    result = presidentApartment * 0.85;
                }
            }
            else if (nights > 15)
            {
                if (room == "apartment")
                {
                    result = apartment * 0.5;
                }
                else if (room == "president apartment")
                {
                    result = presidentApartment * 0.8;
                }
            }

            if (review == "positive")
            {
                result *= 1.25;
            }
            else
            {
                result *= 0.9;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}