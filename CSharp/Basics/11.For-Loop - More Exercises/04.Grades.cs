using System;

class HelloWorld
{
    static void Main()
    {
        int students = int.Parse(Console.ReadLine());
        int g1 = 0;
        int g2 = 0;
        int g3 = 0;
        int g4 = 0;
        double averageGrades = 0;

        for (int i = 1; i <= students; i++)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade < 3)
            {
                g1++;
                averageGrades += grade;
            }
            else if (grade < 4)
            {
                g2++;
                averageGrades += grade;
            }
            else if (grade < 5)
            {
                g3++;
                averageGrades += grade;
            }
            else
            {
                g4++;
                averageGrades += grade;
            }
        }
        Console.WriteLine($"Top students: {(1.0 * g4 / students) * 100.0:f2}%");
        Console.WriteLine($"Between 4.00 and 4.99: {(1.0 * g3 / students) * 100.0:f2}%");
        Console.WriteLine($"Between 3.00 and 3.99: {(1.0 * g2 / students) * 100.0:f2}%");
        Console.WriteLine($"Fail: {(1.0 * g1 / students) * 100.0:f2}%");
        Console.WriteLine($"Average: {averageGrades / students:f2}");
    }
}
