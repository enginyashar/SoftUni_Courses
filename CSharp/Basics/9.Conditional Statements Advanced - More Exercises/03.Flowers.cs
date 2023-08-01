using System;

namespace PB021_ME_CSA_03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrizantema = int.Parse(Console.ReadLine());
            int roza = int.Parse(Console.ReadLine());
            int lale = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());

            double price = 0;

            if (season == "Spring" || season == "Summer")
            {
                price = hrizantema * 2 + roza * 4.1 + lale * 2.5;

                if (season == "Spring" && lale > 7)
                {
                    price *= 0.95;
                }
            }
            else
            {
                price = hrizantema * 3.75 + roza * 4.5 + lale * 4.15;

                if (season == "Winter" && roza >= 10)
                {
                    price *= 0.9;
                }
            }         
                  
            if (holiday == 'Y')
            {
                price *= 1.15;
            }

            if (hrizantema + lale + roza > 20)
            {
                price *= 0.8;
            }

            price += 2;

            Console.WriteLine($"{price:f2}");
        }
    }
}
