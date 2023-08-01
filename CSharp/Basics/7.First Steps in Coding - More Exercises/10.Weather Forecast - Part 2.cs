using System;

namespace WeatherForecastP2
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            double deg = double.Parse(Console.ReadLine());

            if (deg > 35)
            {
                Console.WriteLine("unknown");
            }
            else if (deg >= 26)
            {
                Console.WriteLine("Hot");
            }
            else if (deg >= 20.1)
            {
                Console.WriteLine("Warm");
            }
            else if (deg >= 15.00)
            {
                Console.WriteLine("Mild");
            }
            else if (deg >= 12.00)
            {
                Console.WriteLine("Cool");
            }
            else if (deg > 0)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}