using System;

namespace P10_WL_Exe_03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double cost = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            string action = string.Empty;
            double actionMoney = 0;
            int spendCnt = 0;
            int dayCnt = 0;

            while (money < cost)
            {
                action = Console.ReadLine();
                actionMoney = double.Parse(Console.ReadLine());
                dayCnt++;

                if (action == "spend")
                {
                    money -= actionMoney;

                    if (money < 0)
                    {
                        money = 0;
                    }

                    spendCnt++;
                    if (spendCnt == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{dayCnt}");
                        break;
                    }
                }
                else
                {
                    money += actionMoney;
                    spendCnt = 0;
                }
            }
            if (money >= cost)
            {
                Console.WriteLine($"You saved the money for {dayCnt} days.");
            }
        }
    }
}
