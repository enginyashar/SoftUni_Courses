using System;

class Hospital
{
    static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());

        int treatedPatient = 0;
        int untreatedPatient = 0;
        int doctors = 7;

        for (int i = 1; i <= days; i++)
        {
            if (i % 3 == 0)
            {
                if (untreatedPatient > treatedPatient)
                {
                    doctors++;
                }
            }

            int patient = int.Parse(Console.ReadLine());

            if (patient > doctors)
            {
                untreatedPatient += (patient - doctors);
                treatedPatient += doctors;
            }
            else
            {
                treatedPatient += patient;
            }
        }
        Console.WriteLine($"Treated patients: {treatedPatient}.");
        Console.WriteLine($"Untreated patients: {untreatedPatient}.");
    }
}