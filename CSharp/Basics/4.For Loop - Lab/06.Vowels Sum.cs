﻿using System;
namespace NumbersNto1
{
    class ConsoleApp
    {
        static void Main()
        {
            string text = Console.ReadLine().ToLower();
            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                if (letter == 'a')
                {
                    sum++;
                }
                else if (letter == 'e')
                {
                    sum += 2;
                }
                else if (letter == 'i')
                {
                    sum += 3;
                }
                else if (letter == 'o')
                {
                    sum += 4;
                }
                else if (letter == 'u')
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}