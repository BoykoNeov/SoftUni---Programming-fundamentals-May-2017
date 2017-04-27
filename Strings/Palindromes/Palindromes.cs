// Write a program that extracts from a given text all palindromes, e.g.ABBA, lamal, exe and prints them
// on the console on a single line, separated by comma and space.
// Use spaces, commas, dots, question marks and exclamation marks as word delimiters.
// Print only unique palindromes, sorted lexicographically.

namespace Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palindromes
    {
       public static void Main()
        {
            string[] words = Console.ReadLine()
                .Split(new char[] { ' ','!','?',',','.' }, StringSplitOptions.RemoveEmptyEntries);

            HashSet<string> palindromes = new HashSet<string>();

            foreach (string word in words)
            {
                if (word == (string)string.Join(string.Empty,word.Reverse()))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes.OrderBy(x => x)));
        }
    }
}