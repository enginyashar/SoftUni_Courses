using System;
class SumPrimeNonPrime
{
    static void Main()
    {
        string num = string.Empty;
        int primeSum = 0;
        int nonPrimeSum = 0;

        while ((num = Console.ReadLine().ToLower()) != "stop")
        {
            int conNum = int.Parse(num);
            int countDiv = 0;
            if (conNum < 0)
            {
                Console.WriteLine("Number is negative.");
                continue;
            }
            for (int i = 1; i <= conNum; i++)
            {
                if (conNum % i == 0)
                {
                    countDiv++;
                }
            }
            if (countDiv >= 3)
            {
                nonPrimeSum += conNum;
            }
            else
            {
                primeSum += conNum;
            }
        }
        Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
        Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");

    }
}
