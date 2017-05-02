using System;
using System.Linq;

/// <summary>
///  Task "Character Multiplier" from "String" excercises. 
/// Create a method that takes two strings as arguments and returns the sum of their character codes 
/// multiplied (multiply str1.charAt (0) with str2.charAt (0) and add to the total sum). Then
/// continue with the next two characters. If one of the strings is longer than the other, add the
/// remaining character codes to the total sum without multiplication.
/// </summary>
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