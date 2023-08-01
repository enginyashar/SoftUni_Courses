using System;
class FuelTank
{
    static void Main()
    {
        string fuelType = Console.ReadLine().ToLower();
        double fuelLitre = int.Parse(Console.ReadLine());

        string result = "";

        bool isThisFuel = (fuelType == "diesel" || fuelType == "gasoline" || fuelType == "gas");

        if (isThisFuel)
        {
            if (fuelLitre >= 25)
            {
                result = "You have enough " + fuelType + ".";
            }
            else
            {
                result = "Fill your tank with " + fuelType + "!";
            }
        }
        else
        {
            result = "Invalid fuel!";
        }
        Console.WriteLine(result);
    }
}
