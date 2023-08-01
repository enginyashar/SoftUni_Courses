using System;

class EqualSumsEvenOddPosition
{
    static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());

        for (int i = startNum; i <= endNum; i++)
        {
            string currentNum = i.ToString();
            int evenNum = 0;
            int oddNum = 0;

            for (int j = 0; j < currentNum.Length; j++)
            {
                int num = int.Parse(currentNum[j].ToString());

                if (j % 2 == 0)
                {
                    evenNum += num;
                }
                else
                {
                    oddNum += num;
                }
            }
            if (evenNum == oddNum)
            {
                Console.Write(i + " ");
            }
        }
    }
}