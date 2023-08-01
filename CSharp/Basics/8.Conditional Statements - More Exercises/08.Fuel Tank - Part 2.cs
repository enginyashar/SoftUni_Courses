using System;
class FuelТankPart2
{
    static void Main()
    {
        string fuelType = Console.ReadLine().ToLower();
        double volume = double.Parse(Console.ReadLine());
        string card = Console.ReadLine().ToLower();

        double totalCost = 0;

        if (fuelType == "gas")
        {
            totalCost = volume * 0.93;
            if (card == "yes")
            {
                totalCost -= (volume * 0.08);
            }
        }
        else if (fuelType == "gasoline")
        {
            totalCost = volume * 2.22;
            if (card == "yes")
            {
                totalCost -= (volume * 0.18);
            }
        }
        else if (fuelType == "diesel")
        {
            totalCost = volume * 2.33;
            if (card == "yes")
            {
                totalCost -= (volume * 0.12);
            }
        }

        if (volume > 19 && volume < 26)
        {
            totalCost *= 0.92;
        }
        else if (volume > 25)
        {
            totalCost *= 0.9;
        }

        Console.WriteLine($"{totalCost:f2} lv.");
    }
}