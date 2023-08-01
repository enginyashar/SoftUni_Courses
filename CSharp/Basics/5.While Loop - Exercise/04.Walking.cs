using System;
class Walking
{
    static void Main()
    {
        string steps = "";
        int totalSteps = 0;

        while (totalSteps < 10000 && steps != "Going home")
        {
            steps = Console.ReadLine();

            if (steps == "Going home")
            {
                totalSteps += int.Parse(Console.ReadLine());
                break;
            }
            totalSteps += int.Parse(steps);
        }

        if (totalSteps > 10000)
        {
            Console.WriteLine("Goal reached! Good job!");
            Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
        }
        else
        {
            Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
        }
    }
}
