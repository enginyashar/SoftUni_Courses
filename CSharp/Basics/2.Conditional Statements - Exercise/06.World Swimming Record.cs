using System;

namespace P031_CS_Exe_06.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double total = time * distance + Math.Floor(distance / 15) * 12.5;

            if (record > total)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {total:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {total - record:f2} seconds slower.");
            }
        }
    }
}
