// Task "Character Multiplier" from "String" excercises. Check ../ 09. Programming-Fundamentals-Strings-and-Text-Processing-Exercise.docx for more info

using System;
using System.Linq;

public class CharacterMultiplier
{
    static void Main()
    {
        var inputs = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

        int result = 0;
        string firstString = inputs[0];
        string secondString = inputs[1];


        while (firstString.Length > 0 && secondString.Length > 0)
        {
            result += firstString.First() * secondString.First();
            firstString = firstString.Remove(0, 1);
            secondString = secondString.Remove(0, 1);
        }

        result += AddRemainingCharacters(firstString);
        result += AddRemainingCharacters(secondString);

        Console.WriteLine(result);
    }

    public static int AddRemainingCharacters(string remainingString)
    {
        int output = 0;
        for (int i = 0; i < remainingString.Length; i++)
        {
            output += remainingString[i];
        }

        return output;
    }
}