using System;
class HelloWorld
{
    static void Main()
    {
        double p1Percent = 0;
        double p2Percent = 0;
        double p3Percent = 0;
        double p4Percent = 0;
        double p5Percent = 0;

        int ip1 = 0;
        int ip2 = 0;
        int ip3 = 0;
        int ip4 = 0;
        int ip5 = 0;

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 200)
            {
                ip1++;
            }
            else if (num >= 200 && num <= 399)
            {
                ip2++;
            }
            else if (num >= 400 && num <= 599)
            {
                ip3++;
            }
            else if (num >= 600 && num <= 799)
            {
                ip4++;
            }
            else
            {
                ip5++;
            }
        }

        p1Percent = ip1 * 100.0 / n;
        p2Percent = ip2 * 100.0 / n;
        p3Percent = ip3 * 100.0 / n;
        p4Percent = ip4 * 100.0 / n;
        p5Percent = ip5 * 100.0 / n;

        Console.WriteLine($"{p1Percent:f2}%");
        Console.WriteLine($"{p2Percent:f2}%");
        Console.WriteLine($"{p3Percent:f2}%");
        Console.WriteLine($"{p4Percent:f2}%");
        Console.WriteLine($"{p5Percent:f2}%");
    }
}
