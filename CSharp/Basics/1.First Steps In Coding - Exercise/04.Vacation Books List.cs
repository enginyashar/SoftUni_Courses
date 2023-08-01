using System;

namespace P013_FS_Exe_04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int total = (pages / pagesPerHour) / days;
            Console.WriteLine(total);
        }
    }
}
