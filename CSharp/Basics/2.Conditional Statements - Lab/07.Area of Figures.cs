using System;

namespace P025_CS_Lab_07.AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double a = 0;
            double b = 0;
            double result = 0;

            if (figure == "square")
            {
                a = double.Parse(Console.ReadLine());
                result = a * a;
            }
            else if (figure == "rectangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                result = a * b;
            }
            else if (figure == "circle")
            {
                a = double.Parse(Console.ReadLine());
                result = a * a * Math.PI;
            }
            else
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                result = (a * b) / 2;
            }
            Console.WriteLine(result);
        }
    }
}
