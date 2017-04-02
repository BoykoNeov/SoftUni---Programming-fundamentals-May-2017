//Soft uni debugging excercise from Programing Fundamentals - Methods and debugging

using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine()) + 1;

        const char Search = 'p';
        bool hasMatch = false;

        for (int i = 0; i < text.Length;)
        {
            if (text[i] == Search)
            {
                hasMatch = true;

                int endIndex = i + jump;

                if (endIndex > text.Length)
                {
                    endIndex = text.Length;
                    jump = endIndex - i;
                }

                string matchedString = text.Substring(i, jump);
                Console.WriteLine(matchedString);
                i += jump;
            }
            else
            {
                i++;
            }

        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}