// Read a text, split it into words and distribute them into 3 lists.
// Lower-case words like “programming”, “at” and “databases” – consist of lowercase letters only.
// Upper-case words like “PHP”, “JS” and “SQL” – consist of uppercase letters only.
// Mixed-case words like “C#”, “SoftUni” and “Java” – all others.
// Use the following separators between the words: { ',', ';', ':', '.', '!', '(', ')', '&', '\'', '\"', '\\', '/', '[', ']', ' ' }
// Print the 3 lists

using System;
using System.Collections.Generic;
using System.Linq;

public class SplitByWordCasing
{
    public static void Main()
    {
        List<string> input = Console.ReadLine()
            .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '\'', '\"', '\\', '/', '[', ']', ' ' }, StringSplitOptions
            .RemoveEmptyEntries).ToList();

        var allUppercase = new List<string>();
        var allLowercase = new List<string>();
        var mixedCase = new List<string>();

        foreach (string word in input)
        {
            bool containsNonLetter = false;
            foreach (char symbol in word)
            {
                if (!char.IsLetter(symbol))
                {
                    mixedCase.Add(word);
                    containsNonLetter = true;
                    break;
                }
            }
            if (containsNonLetter == true)
            {
                continue;
            }
            if (word == word.ToUpper())
            {
                allUppercase.Add(word);
            }
            else if (word == word.ToLower())
            {
                allLowercase.Add(word);
            }
            else
            {
                mixedCase.Add(word);
            }

        }

        Console.WriteLine($"Lower-case: {string.Join(", ", allLowercase)}");
        Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
        Console.WriteLine($"Upper-case: {string.Join(", ", allUppercase)}");
    }
}