using System;

namespace CircleAreaPerimeter
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double calculatedArea = r * r * Math.PI;
            double calculatedPerimeter = 2 * r * Math.PI;

            Console.WriteLine("{0:F2}", calculatedArea);
            Console.WriteLine("{0:F2}", calculatedPerimeter);
        }
    }
}