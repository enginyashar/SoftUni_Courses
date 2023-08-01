using System;

namespace PB020_ME_CSA_02.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string road = Console.ReadLine();

            double tax = 0;

            if (road == "trail")
            {
                tax = juniors * 5.5 + seniors * 7;
            }
            else if (road == "cross-country")
            {
                tax = juniors * 8 + seniors * 9.5;

                if (juniors + seniors >= 50)
                {
                    tax *= 0.75;
                }
            }
            else if (road == "downhill")
            {
                tax = juniors * 12.25 + seniors * 13.75;
            }
            else
            {
                tax = juniors * 20 + seniors * 21.5;
            }
            tax *= 0.95;
            Console.WriteLine($"{tax:f2}");
        }
    }
}
