﻿using System;

namespace CelsiusToFahrenheit
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("{0:F2}", fahrenheit);
        }
    }
}