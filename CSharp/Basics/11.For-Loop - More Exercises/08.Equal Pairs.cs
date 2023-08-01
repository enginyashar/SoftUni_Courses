using System;

class EqualPairs
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());

        int sum = 0;
        int prevSum = 0;
        int maxDiff = int.MinValue;
        int diff = 0;

        for (int i = 1; i <= numbers; i++)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            sum = a + b;

            if (i > 1)
            {
                diff = Math.Abs(sum - prevSum);
            }

            if (diff > maxDiff)
            {
                maxDiff = diff;
            }

            prevSum = sum;
            sum = 0;
        }

        if (maxDiff == 0)
        {
            Console.WriteLine($"Yes, value={prevSum}");
        }
        else
        {
            Console.WriteLine($"No, maxdiff={maxDiff}");
        }

    }
}
