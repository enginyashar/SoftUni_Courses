using System;
class ReportSystem
{
    static void Main()
    {
        int expectedSales = int.Parse(Console.ReadLine());
        int totalSales = 0;
        int count = 0;

        int countCS = 0;
        int countCC = 0;
        double totalCS = 0.0;
        double totalCC = 0.0;


        while (true)
        {
            count++;
            string amount = Console.ReadLine();

            if (amount == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
                break;
            }

            int conAmount = Int32.Parse(amount);


            if (count % 2 == 0)
            {
                if (conAmount < 10)
                {
                    Console.WriteLine("Error in transaction!");
                }
                else
                {
                    countCC++;
                    totalCC += conAmount;
                    totalSales += conAmount;
                    Console.WriteLine("Product sold!");
                }
            }
            else
            {
                if (conAmount > 100)
                {
                    Console.WriteLine("Error in transaction!");
                }
                else
                {
                    countCS++;
                    totalCS += conAmount;
                    totalSales += conAmount;
                    Console.WriteLine("Product sold!");
                }
            }

            if (expectedSales <= totalSales)
            {
                Console.WriteLine($"Average CS: {totalCS / countCS:f2}");
                Console.WriteLine($"Average CC: {totalCC / countCC:f2}");
                break;
            }
        }
    }
}
