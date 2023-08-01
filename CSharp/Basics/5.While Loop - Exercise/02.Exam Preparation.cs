using System;

namespace P10_WL_Exe_01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedQty = int.Parse(Console.ReadLine());
            int problemCnt = 0;
            int problemGrade = 0;
            int failCnt = 0;
            string problemName = string.Empty;
            string lastProblemName = string.Empty;
            double averageGrade = 0;

            while (true)
            {
                problemName = Console.ReadLine();

                if (problemName == "Enough")
                {
                    averageGrade = averageGrade / problemCnt;
                    Console.WriteLine($"Average score: {averageGrade:f2}");
                    Console.WriteLine($"Number of problems: {problemCnt}");
                    Console.WriteLine($"Last problem: {lastProblemName}");
                    break;
                }

                problemGrade = int.Parse(Console.ReadLine());
                averageGrade += problemGrade;
                problemCnt++;
                lastProblemName = problemName;

                if (problemGrade <= 4)
                {
                    failCnt++;

                    if (failCnt == failedQty)
                    {
                        Console.WriteLine($"You need a break, {failedQty} poor grades.");
                        break;
                    }
                }
            }
        }
    }
}
