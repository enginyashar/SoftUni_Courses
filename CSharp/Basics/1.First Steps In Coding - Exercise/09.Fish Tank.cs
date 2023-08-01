using System;

namespace P018_FS_Exe_09.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());
            int height  = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double total = length * weight * height * 0.001 * (1 - percent / 100.0);

            Console.WriteLine(total);
        }
    }
}
