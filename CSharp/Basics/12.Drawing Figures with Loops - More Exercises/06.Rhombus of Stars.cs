using System;

class RhombusofStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // top part
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            Console.Write("*");

            for (int k = 1; k < i; k++)
            {
                Console.Write(" *");
            }
            Console.WriteLine("");
        }

        // bottom part  
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            for (int k = 1; k < i; k++)
            {
                Console.Write(" *");
            }
            Console.WriteLine("");
        }
    }
}
