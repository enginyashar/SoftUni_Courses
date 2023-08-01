using System;

namespace P041_CSA_Lab_08.CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int num = 12;

            switch (day)
            {
                case "Wednesday":
                case "Thursday":
                    num = 14;
                    break;
                case "Saturday":
                case "Sunday":
                    num = 16;
                    break;
                default:
                    break;
            }
            Console.WriteLine(num);
        }
    }
}
