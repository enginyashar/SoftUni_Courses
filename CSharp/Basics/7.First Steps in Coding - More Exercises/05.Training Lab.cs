using System;

namespace TrainingLab
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            double wM = double.Parse(Console.ReadLine());
            double hM = double.Parse(Console.ReadLine());

            double wCmOstatuk = (wM * 100) % 120;
            double wCmPlaces = (wM * 100 - wCmOstatuk) / 120;

            double hCmOstatuk = (hM * 100 - 100) % 70;
            double hCmPlaces = (hM * 100 - 100 - hCmOstatuk) / 70;

            Console.WriteLine(wCmPlaces * hCmPlaces - 3);
        }
    }
}