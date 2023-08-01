using System;

namespace P014_FS_Exe_05.SuppliesforSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int pencil = int.Parse(Console.ReadLine());
            int marker = int.Parse(Console.ReadLine());
            int detergent = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());
            double total = (pencil * 5.8 + marker * 7.2 + detergent * 1.2) * (1 - (percent * 1 / 100.0));
            Console.WriteLine(total);
        }
    }
}
