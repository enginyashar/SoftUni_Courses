using System;
class ChristmasTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int spaceCnt = n;
        int starsCnt = 0;

        for (int i = 0; i < n + 1; i++)
        {
            Console.Write(new string(' ', spaceCnt));
            Console.Write(new string('*', starsCnt));
            Console.Write(" | ");
            Console.Write(new string('*', starsCnt));
            Console.WriteLine();

            spaceCnt--;
            starsCnt++;
        }
    }
}
