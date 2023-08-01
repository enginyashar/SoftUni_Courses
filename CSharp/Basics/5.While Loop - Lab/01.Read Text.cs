using System;

class ReadText
{
    static void Main()
    {
        while (true)
        {
            string text = Console.ReadLine();

            if (text == "Stop")
            {
                break;
            }
            Console.WriteLine(text);
        }
    }
}