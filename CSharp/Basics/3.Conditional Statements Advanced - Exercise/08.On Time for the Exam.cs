using System;

namespace HotelRoom
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinutes;
            int arriveTime = arriveHour * 60 + arriveMinutes;
            int difference = arriveTime - examTime;

            int calH = Math.Abs(difference / 60);
            int calM = Math.Abs(difference % 60);

            string early = "Early";
            string onTime = "On time";
            string late = "Late";

            string studentArrival = late;

            if (difference < -30)
            {
                studentArrival = early;
            }
            else if (difference <= 0)
            {
                studentArrival = onTime;
            }

            string result = string.Empty;
            if (difference != 0)
            {
                if (calH > 0)
                {
                    result = string.Format("{0}:{1:00} hours", calH, calM);
                }
                else
                {
                    result = calM + " minutes";
                }

                if (difference < 0)
                {
                    result += " before the start";
                }
                else
                {
                    result += " after the start";
                }
            }

            Console.WriteLine(studentArrival);
            if (!string.IsNullOrEmpty(result))
            {
                Console.WriteLine(result);
            }
        }
    }
}