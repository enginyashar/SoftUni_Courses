using System;

class HelloWorld
{
    static void Main()
    {
        int months = int.Parse(Console.ReadLine());

        double totalElectricity = 0;
        double totalOthers = 0;

        for (int i = 1; i <= months; i++)
        {
            double eBill = double.Parse(Console.ReadLine());
            totalElectricity += eBill;
            totalOthers += (20 + 15 + eBill) * 1.2;
        }

        double average = (totalOthers + totalElectricity + (20.0 * months) + (15.0 * months)) / months;

        Console.WriteLine($"Electricity: {totalElectricity:f2} lv");
        Console.WriteLine($"Water: {20.0 * months:f2} lv");
        Console.WriteLine($"Internet: {15.0 * months:f2} lv");
        Console.WriteLine($"Other: {totalOthers:f2} lv");
        Console.WriteLine($"Average: {average:f2} lv");
    }
}
