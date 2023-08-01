using System;

namespace WasherMachine
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            int detergentBottle = int.Parse(Console.ReadLine());
            int detergentLitre = detergentBottle * 750;

            int count = 0;
            int dish = 0;
            int pot = 0;

            while (true)
            {
                count++;
                string dishes = Console.ReadLine();

                if (dishes == "End")
                {
                    Console.WriteLine("Detergent was enough!");
                    Console.WriteLine($"{dish} dishes and {pot} pots were washed.");
                    Console.WriteLine($"Leftover detergent {detergentLitre} ml.");
                    break;
                }

                int parseDishes = Int32.Parse(dishes);

                if (count % 3 == 0)
                {
                    detergentLitre -= (parseDishes * 15);
                    pot += parseDishes;
                }
                else
                {
                    detergentLitre -= (parseDishes * 5);
                    dish += parseDishes;
                }

                if (detergentLitre < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(detergentLitre)} ml. more necessary!");
                    break;
                }

            }
        }
    }
}