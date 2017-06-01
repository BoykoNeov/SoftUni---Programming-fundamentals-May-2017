/// <summary>
/// Create a program to check if given symbol is digit, vowel or any other symbol.
/// </summary>
using System;
using System.Linq;

public class VowelOrDigit
{
    public static void Main()
    {
        char symbol = char.Parse(Console.ReadLine().ToUpper());

        char[] vowels = new char[] { 'A', 'E', 'U', 'I', 'O' };

        if (char.IsDigit(symbol))
        {
            Console.WriteLine("digit");
        }
        else if (char.IsLetter(symbol) && vowels.Contains(symbol))
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}