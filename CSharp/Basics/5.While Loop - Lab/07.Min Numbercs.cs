using System;

class MinNumber
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        int min = Int32.MaxValue;

        while (input != "stop")
        {
            int conInput = Int32.Parse(input);

            if (conInput <= min)
            {
                min = conInput;
            }
            input = Console.ReadLine().ToLower();
        }
        Console.WriteLine(min);
    }
}
