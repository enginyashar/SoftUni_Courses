using System;

namespace P06_CSA_Exe_06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine());
            string num = string.Empty;

            double result = 0;
            
            if (op == '+')
            {
                result = n1 + n2;
            }
            else if (op == '-')
            {
                result = n1 - n2;
            }
            else if (op == '*')
            {
                result = n1 * n2;
            }
            else if (op == '/' && n2 != 0)
            {
                result = 1.0 * n1 / n2;
            }
            else if (op == '%' && n2 != 0)
            {
                result = n1 % n2;
            }

            if (result % 2 == 0)
            {
                num = "even";
            }
            else
            {
                num = "odd";
            }

            if (n2 == 0 && (op == '/' || op == '%'))
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else
            {
                if (op == '+' || op == '-' || op == '*')
                {
                    Console.WriteLine($"{n1} {op} {n2} = {result} - {num}");
                }
                else if (op == '%')
                {                    
                    Console.WriteLine($"{n1} {op} {n2} = {result}");
                }
                else
                {
                    Console.WriteLine($"{n1} {op} {n2} = {result:f2}");
                }
            }            
        }
    }
}