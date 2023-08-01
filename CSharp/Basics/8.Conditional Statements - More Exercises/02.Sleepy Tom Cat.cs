using System;

namespace SleepyTomCat
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            int freeDays = int.Parse(Console.ReadLine());

            int TomSleepyDays = 30000;
            int playTime = freeDays * 127 + (365 - freeDays) * 63;
            int difference = TomSleepyDays - playTime;
            int hours = difference / 60;
            int minutes = difference % 60;

            if (TomSleepyDays > playTime)
            {
                Console.WriteLine($"Tom sleeps well\n{hours} hours and {minutes} minutes less for play");
            }
            else
            {
                Console.WriteLine($"Tom will run away\n{hours * (-1)} hours and {minutes * (-1)} minutes more for play");
            }
        }
    }
}