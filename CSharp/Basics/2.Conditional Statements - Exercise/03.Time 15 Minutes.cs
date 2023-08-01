using System;

namespace P028_CS_Exe_03.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int total = hours * 60 + minutes + 15;

            int timeHH = total / 60;
            int timeMM = total % 60;

            if (timeHH > 23)
            {
                timeHH = 0;
            }

            Console.WriteLine($"{timeHH}:{timeMM:00}");
        }
    }
}
