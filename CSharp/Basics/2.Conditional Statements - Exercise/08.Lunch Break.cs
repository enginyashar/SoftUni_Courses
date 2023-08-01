using System;

namespace P033_CS_Exe_08.LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int episode = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double time = breakTime - (breakTime / 4.0) - (breakTime / 8.0);

            if (time >= episode)
            {
                Console.WriteLine($"You have enough time to watch {serial} and left with {Math.Ceiling(time - episode)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serial}, you need {Math.Ceiling(episode - time)} more minutes.");
            }
        }
    }
}
