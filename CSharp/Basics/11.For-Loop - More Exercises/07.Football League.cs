using System;
using System.IO;
using System.Text;

class FootballLeague
{
    static void Main()
    {
        int capacityStadion = int.Parse(Console.ReadLine());
        int fens = int.Parse(Console.ReadLine());

        double sA = 0;
        double sB = 0;
        double sV = 0;
        double sG = 0;

        for (int i = 1; i <= fens; i++)
        {
            char sector = Console.ReadLine()[0];

            if (sector == 'A')
            {
                sA++;
            }
            else if (sector == 'B')
            {
                sB++;
            }
            else if (sector == 'V')
            {
                sV++;
            }
            else if (sector == 'G')
            {
                sG++;
            }
        }
        Console.WriteLine($"{(sA / fens) * 100.0:f2}%");
        Console.WriteLine($"{(sB / fens) * 100.0:f2}%");
        Console.WriteLine($"{(sV / fens) * 100.0:f2}%");
        Console.WriteLine($"{(sG / fens) * 100.0:f2}%");
        Console.WriteLine($"{(1.0 * fens / capacityStadion) * 100.0:f2}%");
    }
}
