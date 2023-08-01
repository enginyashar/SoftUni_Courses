using System;

namespace P044_CSA_Lab_11.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());
            double total = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        total = 2.5;
                        break;
                    case "apple":
                        total = 1.2;
                        break;
                    case "orange":
                        total = 0.85;
                        break;
                    case "grapefruit":
                        total = 1.45;
                        break;
                    case "kiwi":
                        total = 2.7;
                        break;
                    case "pineapple":
                        total = 5.5;
                        break;
                    case "grapes":
                        total = 3.85;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        total = 2.7;
                        break;
                    case "apple":
                        total = 1.25;
                        break;
                    case "orange":
                        total = 0.9;
                        break;
                    case "grapefruit":
                        total = 1.6;
                        break;
                    case "kiwi":
                        total = 3.0;
                        break;
                    case "pineapple":
                        total = 5.6;
                        break;
                    case "grapes":
                        total = 4.2;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            total *= qty;

            if (total != 0)
            {
                Console.WriteLine($"{total:f2}");
            }
        }
    }
}
