using System;

namespace P016_FS_Exe_07.FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chikenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int veganMenu = int.Parse(Console.ReadLine());
            double total = (chikenMenu * 10.35 + fishMenu * 12.4 + veganMenu * 8.15) * 1.2 + 2.5;

            Console.WriteLine(total);
        }
    }
}
