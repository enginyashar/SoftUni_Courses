using System;

class ReadText
{
    static void Main()
    {
        string name = Console.ReadLine();
        string psw = Console.ReadLine();

        string pass = Console.ReadLine();

        while (psw != pass)
        {
            pass = Console.ReadLine();
        }
        Console.WriteLine($"Welcome {name}!");
    }
}
