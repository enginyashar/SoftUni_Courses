using System;
class Cake
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());

        int cake = width * length;
        string decrease = "";

        while (cake >= 0 && decrease != "STOP")
        {
            decrease = Console.ReadLine();
            if (decrease == "STOP")
            {
                break;
            }
            int convert = int.Parse(decrease);
            cake -= convert;
        }

        if (cake <= 0)
        {
            Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
        }
        else
        {
            Console.WriteLine($"{cake} pieces are left.");
        }
    }
}
