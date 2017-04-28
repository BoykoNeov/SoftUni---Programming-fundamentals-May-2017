// Write a program that converts a string to a sequence of Unicode character literals

    using System;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            foreach (char letter in input)
            {
                Console.Write($"\\u{(byte)letter:x4}");
            }
        }
    }