using System;

namespace P030_CS_Exe_05.Godzillavs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double statistDress = double.Parse(Console.ReadLine());

            if (statist > 150)
            {
                statistDress *= 0.9;
            }

            double total = budget * 0.1 + statist * statistDress * 1.0;
                        
            if (total > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {total - budget :f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - total :f2} leva left.");
            }
        }
    }
}
