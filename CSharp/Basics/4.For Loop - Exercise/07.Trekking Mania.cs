using System;

class Oscar
{
    static void Main(string[] args)
    {
        int groups = int.Parse(Console.ReadLine());

        double countMusala = 0;
        double countMonblan = 0;
        double countKilimanjaro = 0;
        double countK2 = 0;
        double countEverest = 0;

        int totalClimbers = 0;

        for (int i = 0; i < groups; i++)
        {
            int climbers = int.Parse(Console.ReadLine());

            if (climbers < 6)
            {
                countMusala += climbers;
            }
            else if (climbers < 13)
            {
                countMonblan += climbers;
            }
            else if (climbers < 26)
            {
                countKilimanjaro += climbers;
            }
            else if (climbers < 41)
            {
                countK2 += climbers;
            }
            else
            {
                countEverest += climbers;
            }

            totalClimbers += climbers;
        }

        double MusalaPercent = countMusala / totalClimbers * 100;
        double MonblanPercent = countMonblan / totalClimbers * 100;
        double KilimanjaroPercent = countKilimanjaro / totalClimbers * 100;
        double K2Percent = countK2 / totalClimbers * 100;
        double EverestPercent = countEverest / totalClimbers * 100;

        Console.WriteLine($"{MusalaPercent:f2}%");
        Console.WriteLine($"{MonblanPercent:f2}%");
        Console.WriteLine($"{KilimanjaroPercent:f2}%");
        Console.WriteLine($"{K2Percent:f2}%");
        Console.WriteLine($"{EverestPercent:f2}%");
    }
}