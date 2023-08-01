using System;

namespace P012_FS_Exe_03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double yearlyPer = double.Parse(Console.ReadLine());

            double total = deposit + term * ((deposit * (yearlyPer / 100)) / 12);

            Console.WriteLine(total);
        }
    }
}
