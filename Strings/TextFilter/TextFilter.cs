using System;

/// <summary>
/// Write a program that takes a text and a string of banned words. 
/// All words included in the ban list should be replaced with asterisks "*", equal to the word's length. 
/// The entries in the ban list will be separated by a comma and space ", ".
/// The ban list should be entered on the first input line and the text on the second input line. 
/// </summary>
public class TextFilter
    {
        public static void Main()
        {
            string[] bannedWords = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (string word in bannedWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }