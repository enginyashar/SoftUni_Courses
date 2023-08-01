using System;

class HelloWorld
{
    static void Main()
    {
        int move = int.Parse(Console.ReadLine());
        int g1 = 0;
        int g2 = 0;
        int g3 = 0;
        int g4 = 0;
        int g5 = 0;
        int g6 = 0;

        double totalPoints = 0;

        for (int i = 1; i <= move; i++)
        {
            int point = int.Parse(Console.ReadLine());

            if (point < 0 || point > 50)
            {
                g6++;
                totalPoints = totalPoints / 2;
            }
            else if (point < 10)
            {
                g1++;
                totalPoints += (point * 0.2);
            }
            else if (point < 20)
            {
                g2++;
                totalPoints += (point * 0.3);
            }
            else if (point < 30)
            {
                g3++;
                totalPoints += (point * 0.4);
            }
            else if (point < 40)
            {
                g4++;
                totalPoints += 50;
            }
            else if (point <= 50)
            {
                g5++;
                totalPoints += 100;
            }
        }
        Console.WriteLine($"{totalPoints:f2}");
        Console.WriteLine($"From 0 to 9: {(1.0 * g1 / move) * 100.0:f2}%");
        Console.WriteLine($"From 10 to 19: {(1.0 * g2 / move) * 100.0:f2}%");
        Console.WriteLine($"From 20 to 29: {(1.0 * g3 / move) * 100.0:f2}%");
        Console.WriteLine($"From 30 to 39: {(1.0 * g4 / move) * 100.0:f2}%");
        Console.WriteLine($"From 40 to 50: {(1.0 * g5 / move) * 100.0:f2}%");
        Console.WriteLine($"Invalid numbers: {(1.0 * g6 / move) * 100.0:f2}%");
    }
}
