using System;

namespace P043_CSA_Lab_10.InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (!((num >= 100 && num <= 200) || num == 0))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
