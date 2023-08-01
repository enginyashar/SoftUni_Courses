using System;

namespace P06_CSA_Exe_02.SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int deg = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            string outfit = string.Empty;
            string shoes = string.Empty;

            if (deg >= 25)
            {
                if (day == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (day == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (deg > 18)
            {
                if (day == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (deg >= 10)
            {
                if (day == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {deg} degrees, get your {outfit} and {shoes}.");
        }
    }
}