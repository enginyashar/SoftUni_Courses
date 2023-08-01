using System;

namespace P10_WL_Exe_01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string mainBook = Console.ReadLine();
            int bookCnt = 0;
            string book = Console.ReadLine();

            while (book != mainBook)
            {
                bookCnt++;
                book = Console.ReadLine();

                if (book == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {bookCnt} books.");
                    break;
                }                
            }

            if (book == mainBook)
            {
                Console.WriteLine($"You checked {bookCnt} books and found it.");
            }
        }
    }
}
