using System;

class Hospital
{
    static void Main(string[] args)
    {
        int cargo = int.Parse(Console.ReadLine());

        double totalCost = 0;
        int totalTonnage = 0;

        double t1 = 0;
        double t2 = 0;
        double t3 = 0;

        for (int i = 1; i <= cargo; i++)
        {
            int tonnage = int.Parse(Console.ReadLine());

            if (tonnage < 4)
            {
                totalCost += (tonnage * 200);
                t1 += tonnage;

            }
            else if (tonnage < 12)
            {
                totalCost += (tonnage * 175);
                t2 += tonnage;
            }
            else
            {
                totalCost += (tonnage * 120);
                t3 += tonnage;
            }
            totalTonnage += tonnage;
        }
        Console.WriteLine($"{totalCost / totalTonnage:f2}");
        Console.WriteLine($"{(t1 / totalTonnage) * 100:f2}%");
        Console.WriteLine($"{(t2 / totalTonnage) * 100:f2}%");
        Console.WriteLine($"{(t3 / totalTonnage) * 100:f2}%");

    }
}