//Soft uni debugging excercise from Programing Fundamentals - Methods and debugging

using System;

/// <summary>
/// The goal of this exercise is to practice debugging techniques in scenarios where a piece of code does not work correctly. Your task is to pinpoint the bug and fix it (without rewriting the entire code). Test your fixed solution in the judge system: 
/// You are given a text and a number count. Your program should search through the text for the letter 'p' (ASCII code 112) and print 'p' along with count letters to its right.
/// For example, we are given the text "phahah put" and count = 3.We find a match of 'p' in the first letter so we print it and the 3 letters to its right.The result is "phah". We continue and find another match of 'p', but there aren't 3 letters to its right, so we print only "put". 
/// Each match should be printed on a separate line.If there are no matches of 'p' in the text, we print "no".
/// - The first line holds the text to be processed (string).
/// - The second line holds the number count.
/// For each match, print the matched substring at separate line.Print "no" if there are no matches.
/// - The number count will be in the range [0 ... 100].
/// </summary>
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