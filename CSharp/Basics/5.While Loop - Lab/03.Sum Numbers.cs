using System;

class ReadText
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int totalSum = 0;

        while (true)
        {
            int sum = int.Parse(Console.ReadLine());
            totalSum += sum;

            if (totalSum >= num)
            {
                Console.WriteLine(totalSum);
                break;
            }
        }
    }
}
