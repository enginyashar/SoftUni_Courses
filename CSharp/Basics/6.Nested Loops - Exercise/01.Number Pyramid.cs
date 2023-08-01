using System;

namespace P13_NL_Exe_01.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                string num = rows.ToString();
                string test = new string("num",rows);
                Console.WriteLine(test);
                Console.WriteLine();
            }
        }
    }
}
