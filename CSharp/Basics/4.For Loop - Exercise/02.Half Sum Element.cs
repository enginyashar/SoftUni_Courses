using System;

namespace P052_FL_Exe_02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num;
                }
            }

            sum -= max;

            if (sum == max)
            {
                Console.WriteLine($"Yes\nSum = {sum}");
            }
            else
            {
                Console.WriteLine($"No\nDiff = {Math.Abs(sum - max)}");
            }
        }
    }
}
