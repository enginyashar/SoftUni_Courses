using System;

class AccountBalance
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        int max = Int32.MinValue;

        while (input != "stop")
        {
            int conInput = Int32.Parse(input);

            if (conInput >= max)
            {
                max = conInput;
            }
            input = Console.ReadLine().ToLower();
        }
        Console.WriteLine(max);
    }
}
