using System;

namespace P06_CSA_Exe_01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string place = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double income = r * c;

            if (place == "Premiere")
            {
                income *= 12.0;
            }
            else if (place == "Normal")
            {
                income *= 7.5;
            }
            else
            {
                income *= 5.0;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
