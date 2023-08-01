using System;

class Oscar
{
    static void Main(string[] args)
    {
        string actorName = Console.ReadLine();
        double startPoint = double.Parse(Console.ReadLine());
        int juryN = int.Parse(Console.ReadLine());

        double totalPoint = startPoint;

        for (int i = 1; i <= juryN; i++)
        {
            string juryName = Console.ReadLine();
            double juryPoint = double.Parse(Console.ReadLine());

            double totalJuryPoint = (juryName.Length * juryPoint) / 2;

            totalPoint += totalJuryPoint;

            if (totalPoint >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoint:f1}!");
                break;
            }
            else if (i == juryN)
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - totalPoint:f1} more!");
            }
        }

    }
}