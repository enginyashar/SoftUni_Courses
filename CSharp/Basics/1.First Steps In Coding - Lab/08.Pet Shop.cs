using System;

namespace P08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());
            double total = dogFood * 2.5 + catFood * 4;
            Console.WriteLine(total + " lv.");
        }
    }
}
