using System;

namespace P017_FS_Exe_08.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());
            double shoes = tax * 0.6;
            double equip = shoes * 0.8;
            double ball = equip * 0.25;
            double acc = ball * 0.2;

            double total = tax + shoes + equip + ball + acc;


            Console.WriteLine(total);
        }
    }
}
