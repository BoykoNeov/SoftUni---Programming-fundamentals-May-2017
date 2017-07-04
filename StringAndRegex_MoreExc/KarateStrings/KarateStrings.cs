using System;
using System.Text;

/// <summary>
/// The most notorious person in SoftUni – Pesho is trying to become a karate master. 
/// Being a programmer, Pesho has no idea how to train, so he decided to train on strings. 
/// His punches are marked with ‘>’. Immediately after the mark, there will be an integer,
/// which signifies the strength of the punch.
/// You should remove x characters (where x is the strength of the punch), starting after 
/// the punch character(‘>’).
/// If you find another punch mark(‘>’) while you’re deleting characters, you should add 
/// the strength to your previous punch.
/// When all characters are processed, print the string without the deleted characters.
/// You should not delete the punch character – ‘>’, but you should delete the integers,
/// which represent the strength.
/// Input
/// You will receive single line with the string, which is used by Pesho for training.
/// Output
/// Print what is left from the string after Pesho’s punches.
/// Constraints
/// You will always receive a strength for the punches
/// The path will consist only of letters from the Latin alphabet, integers and the char ‘>’
/// The strength of the punches will be in the interval [0…9]
/// </summary>
public class KarateStrings
{
    public static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder outputSb = new StringBuilder();
        int kickPower = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '>')
            {
                kickPower += input[i + 1] - 48;
                outputSb.Append('>');
                continue;
            }

            if (kickPower > 0)
            {
                kickPower--;
            }
            else
            {
                outputSb.Append(input[i]);
            }
        }

        Console.WriteLine(outputSb.ToString());
    }
}