using System;

namespace P051_FL_Lab_10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rightSum = 0;
            int leftSum = 0;
            int diff = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    leftSum += num;
                }
                else
                {
                    rightSum += num;
                }
            }

            diff = Math.Abs(rightSum - leftSum);

            if (rightSum == leftSum)
            {
                Console.WriteLine($"Yes\nSum = {rightSum}");
            }
            else
            {
                Console.WriteLine($"No\nDiff = {diff}");
            }
        }
    }
}
