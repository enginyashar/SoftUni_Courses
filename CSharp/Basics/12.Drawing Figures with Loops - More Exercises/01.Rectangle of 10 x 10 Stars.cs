﻿using System;

class Rectangleof10x10Stars
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}