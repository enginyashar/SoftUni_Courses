using System;

class EqualSumsEvenOddPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1111; i <= 9999; i++)
        {
            string currentNum = i.ToString();
            int count = 0;

            for (int j = 0; j <= 3; j++)
            {
                int num = int.Parse(currentNum[j].ToString());

                if (num == 0)
                {
                    break;
                }
                else
                {
                    if (n % num == 0)
                    {
                        count++;
                    }
                }
            }

            if (count >= 4)
            {
                Console.Write($"{i} ");
            }
        }
    }
}