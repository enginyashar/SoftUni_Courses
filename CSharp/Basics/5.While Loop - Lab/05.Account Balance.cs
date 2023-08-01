using System;

class HelloWorld
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        double total = 0.0;

        while (input != "nomoremoney")
        {
            double conInput = double.Parse(input);

            if (conInput > 0)
            {
                total += conInput;
                Console.WriteLine($"Increase: {conInput:f2}");
            }
            else
            {
                Console.WriteLine("Invalid operation!");
                break;
            }
            input = Console.ReadLine().ToLower();
        }
        Console.WriteLine($"Total: {total:f2}");
    }
}
