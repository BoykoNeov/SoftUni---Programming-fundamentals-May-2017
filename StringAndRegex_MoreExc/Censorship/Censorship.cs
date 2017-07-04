using System;
using System.Text.RegularExpressions;

/// <summary>
/// Write a program, which takes as an input a single word and a sentence.
/// Your program should search for the word in the sentence and replace every
/// letter of the word with ‘*’. You should do that for every occurrence of the 
/// word. Replace only words, which are exactly the same case as the given on the first
/// line word. Notice that you should replace the word, even if it is part of another word.
/// Input
/// The input will consist of two lines:
/// On the first line, will be the word, which you have to censor.
/// On the second line, will be the sentence, which you need to censor.
/// Output
/// Print the sentence after it is censored.
/// </summary>
public class Censorship
{
    public static void Main()
    {
        string censorThis = Console.ReadLine();
        string toBeCensored = Console.ReadLine();

        string censored = new string('*', censorThis.Length);
        toBeCensored = Regex.Replace(toBeCensored, censorThis, censored);

        Console.WriteLine(toBeCensored);
    }
}