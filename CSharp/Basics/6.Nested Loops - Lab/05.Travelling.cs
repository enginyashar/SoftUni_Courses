using System;

namespace P12_NL_Lab_05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double cost = 0;

            while (destination != "End")
            {
                double budget = 0;
                cost = double.Parse(Console.ReadLine());

                while (cost > budget)
                {
                    budget += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}