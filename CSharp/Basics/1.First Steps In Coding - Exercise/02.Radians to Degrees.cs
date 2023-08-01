using System;

namespace P011_FS_Exe_02.RadianstoDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double deg = rad * 180 / Math.PI;
            Console.WriteLine(deg);
        }
    }
}
