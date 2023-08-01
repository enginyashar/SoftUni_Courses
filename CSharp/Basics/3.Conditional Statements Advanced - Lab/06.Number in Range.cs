using System;

namespace P039_CSA_Lab_06.NumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string text = "Yes";

            if (!(num >= -100 && num <= 100 && num != 0))
            {
                text = "No";
            }
            Console.WriteLine(text);
        }
    }
}
