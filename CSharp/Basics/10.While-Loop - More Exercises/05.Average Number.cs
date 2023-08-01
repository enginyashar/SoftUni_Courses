using System;
class StreamOfLetters
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0.0;

        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            sum += num;
        }

        Console.WriteLine($"{sum / n:f2}");
    }
}
