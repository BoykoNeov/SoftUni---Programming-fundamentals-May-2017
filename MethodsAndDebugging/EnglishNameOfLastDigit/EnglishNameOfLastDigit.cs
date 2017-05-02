using System;

/// <summary>
/// Reads an integer (a string more correctly) from the console and returns the name of the last digit in English
/// </summary>
public class EnglishNameOfLastDigit
{
    public static void Main()
    {
        string consoleInput = Console.ReadLine();
        Console.WriteLine(NameOfLastDigit((consoleInput[consoleInput.Length - 1])));
    }
    public static string NameOfLastDigit(char input)
    {
        switch (input)
        {
            case '0':
                return "zero";
            case '1':
                return "one";
            case '2':
                return "two";
            case '3':
                return "three";
            case '4':
                return "four";
            case '5':
                return "five";
            case '6':
                return "six";
            case '7':
                return "seven";
            case '8':
                return "eight";
            case '9':
                return "nine";
            default: return string.Empty;
        }
    }
}