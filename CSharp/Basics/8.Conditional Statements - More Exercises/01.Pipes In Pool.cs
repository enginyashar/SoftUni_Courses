using System;

namespace PipesInPool
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double vfull = h * (p1 + p2);

            double p1Procent = (p1 * h * 100) / vfull;
            double p2Procent = (p2 * h * 100) / vfull;

            double vProcent = vfull * 100 / v;
            double overflows = vfull - v;



            if (vProcent <= 100)
            {
                Console.WriteLine($"The pool is {String.Format("{0:F2}", vProcent)}% full. Pipe 1: {String.Format("{0:F2}", p1Procent)}%. Pipe 2: {String.Format("{0:F2}", p2Procent)}%.");
            }
            else
            {
                Console.WriteLine($"For {String.Format("{0:F2}", h)} hours the pool overflows with {String.Format("{0:F2}", overflows)} liters.");
            }
        }
    }
}