using System;
class StreamOfLetters
{
    static void Main()
    {
        string reserve = "";
        string word = "";
        string con = "";

        while (true)
        {
            string letter = Console.ReadLine();
            if (letter == "End")
            {
                Console.WriteLine(reserve);
                break;
            }

            char convert = char.Parse(letter);
            if ((convert >= 'a' && convert <= 'z') || (convert >= 'A' && convert <= 'Z'))
            {
                if (convert == 'c' || convert == 'o' || convert == 'n')
                {
                    if (con.Contains(letter) == true)
                    {
                        word += convert;
                    }
                    else
                    {
                        con += convert;
                    }
                }
                else
                {
                    word += convert;
                }
            }

            if ((con.Contains("c") == true) && (con.Contains("o") == true) && (con.Contains("n") == true))
            {
                word += " ";
                reserve += word;
                word = "";
                con = "";
            }
        }
    }
}
