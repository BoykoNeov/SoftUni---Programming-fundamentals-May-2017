/// <summary>
/// Write a program, which receives a noun and prints the noun in plural. You will receive one of the following cases: 
/// A noun that ends in y – remove the y and add ies
/// A noun that ends in o, ch, s, sh, x or z – add es at the end of the word
/// In all other cases – just add s at the end
/// Input
/// You will receive a single word, which you have to pluralize.
/// Output
/// Print only the word in plural.
/// </summary>
using System;
using System.Linq;
public class WordInPlural
{
    public static void Main()
    {
        var inputWord = Console.ReadLine();
        string output = string.Empty;

        if (inputWord.Last() == 'y')
        {
            output = inputWord.Remove(inputWord.Length - 1, 1) + "ies";
        }

        // A neat example of how it shouldn't be done, but I am feeling annoyed
        else if (new string (inputWord.Skip(inputWord.Length - 2).Take(2).ToArray()) == "ch" ||
            new string(inputWord.Skip(inputWord.Length - 2).Take(2).ToArray()) == "sh" ||
            (inputWord.Last() == 'o') ||
            (inputWord.Last() == 's') ||
            (inputWord.Last() == 'x') ||
            (inputWord.Last() == 'z'))
        {
            output = inputWord + "es";
        }
        else
        {
            output = inputWord + "s";
        }

        Console.WriteLine(output);
    }
}