// Write a program that creates an array containing all letters from the alphabet(a-z). 
// Read a lowercase word from the console and print the index of each of its letters in the letters array

using System;

public class IndexOfLetters
{
    public static void Main()
    {
        char[] charArray = new char[26];
        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            charArray[letter - 97] = letter;
        }

        string input = Console.ReadLine();
        foreach (char letter in input)
        {
            Console.WriteLine($"{charArray[letter - 97]} -> {(letter - 97)}");
        }
    }
}