using System;

class Harvest
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string partOfTheDay = Console.ReadLine().ToLower();

        double taxi = 0.7;

        if (partOfTheDay == "day")
        {
            taxi += (n * 0.79);
        }
        else
        {
            taxi += (n * 0.9);
        }

        double result = 0;
        if (n < 20)
        {
            result = taxi;
        }
        else if (n < 100)
        {
            result = n * 0.09;
        }
        else
        {
            result = n * 0.06;
        }
        Console.WriteLine("{0:f2}", result);
    }
}
