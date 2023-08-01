using System;
class Walking
{
    static void Main()
    {
        double resto = double.Parse(Console.ReadLine());
        double balance = Math.Floor(resto * 100);
        int coin = 0;

        while (balance > 0)
        {
            if (balance >= 200)
            {
                coin++;
                balance -= 200;
            }
            else if (balance >= 100)
            {
                coin++;
                balance -= 100;
            }
            else if (balance >= 50)
            {
                coin++;
                balance -= 50;
            }
            else if (balance >= 20)
            {
                coin++;
                balance -= 20;
            }
            else if (balance >= 10)
            {
                coin++;
                balance -= 10;
            }
            else if (balance >= 5)
            {
                coin++;
                balance -= 5;
            }
            else if (balance >= 2)
            {
                coin++;
                balance -= 2;
            }
            else if (balance >= 1)
            {
                coin++;
                balance -= 1;
            }
        }
        Console.WriteLine(coin);
    }
}
