using System;
class TrainTheTrainers
{
    static void Main()
    {
        int jury = int.Parse(Console.ReadLine());
        int count = 0;
        string presName = string.Empty;
        double final = 0.0;


        while ((presName = Console.ReadLine()) != "Finish")
        {
            double grade = 0;
            double juryNote = 0.0;
            for (int i = 1; i <= jury; i++)
            {
                count++;
                grade = double.Parse(Console.ReadLine());
                juryNote += grade;
            }
            Console.WriteLine($"{presName} - {juryNote / jury:f2}.");
            final += juryNote;
        }
        Console.WriteLine($"Student's final assessment is {(double)final / count:f2}.");
    }
}