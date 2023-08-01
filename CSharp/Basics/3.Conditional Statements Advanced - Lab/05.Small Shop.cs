using System;

namespace P038_CSA_Lab_05.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double total = 0.0;

            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    total = 0.5;
                }
                else if (product == "water")
                {
                    total = 0.8;
                }
                else if (product == "beer")
                {
                    total = 1.2;
                }
                else if (product == "sweets")
                {
                    total = 1.45;
                }
                else if (product == "peanuts")
                {
                    total = 1.6;
                }
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    total = 0.4;
                }
                else if (product == "water")
                {
                    total = 0.7;
                }
                else if (product == "beer")
                {
                    total = 1.15;
                }
                else if (product == "sweets")
                {
                    total = 1.3;
                }
                else if (product == "peanuts")
                {
                    total = 1.5;
                }
            }
            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    total = 0.45;
                }
                else if (product == "water")
                {
                    total = 0.7;
                }
                else if (product == "beer")
                {
                    total = 1.10;
                }
                else if (product == "sweets")
                {
                    total = 1.35;
                }
                else if (product == "peanuts")
                {
                    total = 1.55;
                }
            }
            total *= quantity;
            Console.WriteLine(total);
        }
    }
}
