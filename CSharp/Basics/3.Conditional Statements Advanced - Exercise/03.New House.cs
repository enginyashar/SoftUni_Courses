using System;

namespace P06_CSA_Exe_03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int qty = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double cost = qty;

            if (flower == "Roses")
            {
                cost *= 5.0;

                if (qty > 80)
                {
                    cost *= 0.9;
                }
            }
            else if (flower == "Dahlias")
            {
                cost *= 3.8;

                if (qty > 90)
                {
                    cost *= 0.85;
                }
            }
            else if (flower == "Tulips")
            {
                cost *= 2.8;

                if (qty > 80)
                {
                    cost *= 0.85;
                }
            }
            else if (flower == "Narcissus")
            {
                cost *= 3.0;

                if (qty < 120)
                {
                    cost *= 1.15;
                }
            }
            else if (flower == "Gladiolus")
            {
                cost *= 2.5;

                if (qty < 80)
                {
                    cost *= 1.2;
                }
            }

            if (budget >= cost)
            {
                Console.WriteLine($"Hey, you have a great garden with {qty} {flower} and {budget - cost:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {cost - budget:f2} leva more.");
            }
        }
    }
}
