using System;
class Moving
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        int box = width * length * height;
        string decrease = "";

        while (box >= 0)
        {
            decrease = Console.ReadLine();
            if (decrease == "Done")
            {
                break;
            }
            int convert = int.Parse(decrease);
            box -= convert;
        }

        if (box <= 0)
        {
            Console.WriteLine($"No more free space! You need {Math.Abs(box)} Cubic meters more.");
        }
        else
        {
            Console.WriteLine($"{box} Cubic meters left.");
        }
    }
}
