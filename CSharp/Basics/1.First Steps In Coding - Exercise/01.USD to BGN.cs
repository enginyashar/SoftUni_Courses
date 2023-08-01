using System;

namespace P10_FS_Exe_01.USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;
            Console.WriteLine(bgn);
        }
    }
}
