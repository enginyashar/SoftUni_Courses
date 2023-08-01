using System;

namespace P015_FS_Exe_06.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int naylon = int.Parse(Console.ReadLine()) + 2;
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double total = naylon * 1.5 + paint * 1.1 * 14.5 + thinner * 5.0 + 0.40;
            total += (total * 0.3 * hours); 

            Console.WriteLine(total);
        }
    }
}
