using System;

class Oscar
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int startPoint = int.Parse(Console.ReadLine());

        int countW = 0;
        int totalPoint = startPoint;

        for (int i = 0; i < n; i++)
        {
            string stage = Console.ReadLine().ToLower();

            if (stage == "w")
            {
                totalPoint += 2000;
                countW++;
            }
            else if (stage == "f")
            {
                totalPoint += 1200;
            }
            else if (stage == "sf")
            {
                totalPoint += 720;
            }
        }

        Console.WriteLine($"Final points: {totalPoint}");
        Console.WriteLine($"Average points: {Math.Floor((totalPoint - startPoint) / n * 1.0)}");
        Console.WriteLine($"{1.0 * countW / n * 100.0:f2}%");
    }
}