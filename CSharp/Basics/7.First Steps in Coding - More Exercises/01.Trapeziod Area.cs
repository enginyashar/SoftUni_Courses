﻿using System;
using System.Globalization;

namespace TrapeziodArea
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double s = (b1 + b2) * h / 2;

            Console.WriteLine("{0:F2}", s);
        }
    }
}
