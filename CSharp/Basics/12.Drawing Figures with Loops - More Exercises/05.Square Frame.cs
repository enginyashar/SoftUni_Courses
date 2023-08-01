using System;

class RectangleofNxNStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i == 1 || i == n)
            {
                Console.Write("+ ");
                for (int j = 1; j <= n - 2; j++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("+");
            }
            else
            {
                Console.Write("| ");
                for (int k = 1; k <= n - 2; k++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("|");
            }
        }
    }
}