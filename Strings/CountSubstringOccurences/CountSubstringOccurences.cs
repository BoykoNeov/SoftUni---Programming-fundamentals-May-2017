using System;

/// <summary>
/// Write a program to find how many times a given string appears in a 
/// given text as substring.The text is given at the first input line.
/// The search string is given at the second input line. The output is an integer number.
/// Please ignore the character casing.Overlapping between occurrences is allowed.
/// </summary>
public class CountSubstringOccurences
{
    public static void Main()
    {
        string input = Console.ReadLine().ToLower();
        string pattern = Console.ReadLine().ToLower();
        int occurences = 0;
        int index = 0;

        while((index = input.IndexOf(pattern, index)) > -1)
        {
            index++;
            occurences++;
        }

        Console.WriteLine(occurences);
    }
}