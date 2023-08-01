using System;

class Harvest
{
    static void Main()
    {
        /* x -> X kv.m. vineyard;
          y -> Y grapes for 1 kv.m
          z -> Z needed vine (litre)*/

        int x = int.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        double vine = (x * y * 0.4) / 2.5;

        if (vine < z)
        {
            Console.WriteLine($"It will be a tough winter! More {Math.Floor(z - vine)} liters wine needed.");
        }
        else
        {
            Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(vine)} liters.");
            Console.WriteLine($"{Math.Ceiling(vine - z)} liters left -> {Math.Ceiling((vine - z) / workers)} liters per person.");
        }
    }
}
