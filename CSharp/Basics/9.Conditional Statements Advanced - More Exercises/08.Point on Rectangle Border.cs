using System;

namespace PB026_ME_CSA_08.PointOnRectangleBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool checkX = (x == x1 || x == x2) && (y1 <= y && y <= y2);
            bool checkY = (y == y1 || y == y2) && (x1 <= x && x <= x2);

            if (checkX || checkY)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
