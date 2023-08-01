using System;

class MinNumber
{
    static void Main()
    {
        string name = Console.ReadLine();
        int count = 0;
        double total = 0.0;
        int exc = 0;


        while (count != 12)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade < 4)
            {
                exc++;
                if (exc == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {count} grade");
                    break;
                }
            }
            else
            {
                total += grade;
            }
            count++;
        }
        if (count == 12)
        {
            Console.WriteLine($"{name} graduated. Average grade: {total / 12:f2}");
        }
    }
}