using System;

namespace P040_CSA_Lab_07.WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            string text = "closed";

            if (hour >= 10 && hour <= 18 && day != "Sunday")
            {
                    text = "open";                
            }
            Console.WriteLine(text);
        }
    }
}
