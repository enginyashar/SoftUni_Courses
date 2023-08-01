using System;

namespace P045_CSA_Lab_12.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double income = double.Parse(Console.ReadLine());
            double result = 0;

            if (city == "Sofia")
            {
                if (income > 10000)
                {
                    result = income * 0.12;
                }
                else if (income > 1000)
                {
                    result = income * 0.08;
                }
                else if (income > 500)
                {
                    result = income * 0.07;
                }
                else if (income > 0)
                {
                    result = income * 0.05;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Varna")
            {
                if (income > 10000)
                {
                    result = income * 0.13;
                }
                else if (income > 1000)
                {
                    result = income * 0.1;
                }
                else if (income > 500)
                {
                    result = income * 0.075;
                }
                else if (income > 0)
                {
                    result = income * 0.045;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (income > 10000)
                {
                    result = income * 0.145;
                }
                else if (income > 1000)
                {
                    result = income * 0.12;
                }
                else if (income > 500)
                {
                    result = income * 0.08;
                }
                else if (income > 0)
                {
                    result = income * 0.055;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {                
                Console.WriteLine("error");
            }

            if (result != 0)
            {
                Console.WriteLine($"{result:f2}");
            }            
        }
    }
}
