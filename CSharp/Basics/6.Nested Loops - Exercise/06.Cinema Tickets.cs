using System;

class EqualSumsEvenOddPosition
{
    static void Main()
    {
        string movieName = string.Empty;
        int kidTickets = 0;
        int studentTickets = 0;
        int standardTickets = 0;
        int count = 0;

        double percentFull = 0;
        double percentKid = 0;
        double percentStudent = 0;
        double percentStandard = 0;

        while ((movieName = Console.ReadLine()) != "Finish")
        {
            int place = int.Parse(Console.ReadLine());
            int currentCount = 0;
            for (int i = 1; i <= place; i++)
            {
                string ticket = Console.ReadLine();

                if (ticket == "kid")
                {
                    kidTickets++;
                }
                else if (ticket == "student")
                {
                    studentTickets++;
                }
                else if (ticket == "standard")
                {
                    standardTickets++;
                }
                else
                {
                    break;
                }
                currentCount++;
            }
            percentFull = (double)currentCount / place * 100.0;
            Console.WriteLine($"{movieName} - {percentFull:f2}% full.");
            count += currentCount;
        }
        percentKid = (double)kidTickets / count * 100.0;
        percentStudent = (double)studentTickets / count * 100.0;
        percentStandard = (double)standardTickets / count * 100.0;

        Console.WriteLine($"Total tickets: {count}");
        Console.WriteLine($"{percentStudent:f2}% student tickets.");
        Console.WriteLine($"{percentStandard:f2}% standard tickets.");
        Console.WriteLine($"{percentKid:f2}% kids tickets.");
    }
}