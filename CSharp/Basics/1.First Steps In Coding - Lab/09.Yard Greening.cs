using System;

namespace P09.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double total = area * 7.61;
            Console.WriteLine($"The final price is: {total * 0.82} lv.");
            Console.WriteLine($"The discount is: {total * 0.18} lv.");            
        }
    }
}
