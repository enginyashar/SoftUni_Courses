using System;
class HelloWorld
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        double washingMachinePrice = double.Parse(Console.ReadLine());
        double toyPrice = double.Parse(Console.ReadLine());

        double birthDayMoney = 10;
        double toysQty = 0;
        double savedMoney = 0;

        for (int i = 1; i <= age; i++)
        {
            if (i % 2 == 0)
            {
                savedMoney += (birthDayMoney - 1);
                birthDayMoney += 10;
            }
            else
            {
                toysQty++;
            }
        }

        savedMoney += toysQty * toyPrice;

        double diff = savedMoney - washingMachinePrice;
        Console.WriteLine(savedMoney >= washingMachinePrice ? $"Yes! {diff:0.00}" : $"  No! {Math.Abs(diff):0.00}");

    }
}
