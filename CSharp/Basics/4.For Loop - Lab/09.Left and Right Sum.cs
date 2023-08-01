using System;

namespace P050_FL_Lab_09.LeftandRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rightSum = 0;
            int leftSum = 0;
            int diff = 0;

            for (int i = 1; i <= 2 * n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i > n)
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
                Console.WriteLine($"Yes, sum = {rightSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {diff}");
            }

        }
    }
}
