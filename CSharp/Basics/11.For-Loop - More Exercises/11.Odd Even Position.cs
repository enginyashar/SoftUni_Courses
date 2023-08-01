using System;

class HelloWorld
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double evenMax = double.MinValue;
        double evenMin = double.MaxValue;
        double oddMax = double.MinValue;
        double oddMin = double.MaxValue;

        double evenSum = 0;
        double oddSum = 0;

        for (int i = 1; i <= n; i++)
        {
            double num = double.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                evenSum += num;

                if (i > 1)
                {
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                }
            }
            else
            {
                oddSum += num;

                if (i > 0)
                {
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                }
            }
        }

        Console.WriteLine($"OddSum={oddSum:f2},");
        if (oddMin == double.MaxValue)
        {
            Console.WriteLine("OddMin=No,");
            Console.WriteLine("OddMax=No,");
        }
        else
        {
            Console.WriteLine($"OddMin={oddMin:f2},");
            Console.WriteLine($"OddMax={oddMax:f2},");
        }

        Console.WriteLine($"EvenSum={evenSum:f2},");
        if (evenMin == double.MaxValue)
        {
            Console.WriteLine("EvenMin=No,");
            Console.WriteLine("EvenMax=No");
        }
        else
        {
            Console.WriteLine($"EvenMin={evenMin:f2},");
            Console.WriteLine($"EvenMax={evenMax:f2}");
        }

    }
}
