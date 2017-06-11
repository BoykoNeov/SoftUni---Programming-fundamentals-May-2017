using System;
using System.Linq;

/// <summary>
/// You will receive an array of strings and you have to execute some command upon it. You can receive three types of commands: 
/// Reverse – reverse the array
/// Distinct – delete all non-unique elements from the array
/// Replace {index} {string} – replace the element at the given index with the string, which will be given to you
/// Input
/// On the first line, you will receive the string array
/// On the second line, you will receive n – the number of lines, which will follow
/// On the next n lines – you will receive commands
/// Output
/// At the end print the array in the following format:
/// {1st element}, {2nd element}, {3rd element} … {nth element}
/// Constraints
/// For separator will be used only single whitespace
/// n will be integer in the interval[1…100]
/// </summary>
public class ManipulateArray
{
    public static void Main()
    {
        string[] input = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.None)
            .ToArray();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] commands = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.None)
                .ToArray();


            if (commands[0] == "Reverse")
            {
                input = input.Reverse().ToArray();
            }
            else if (commands[0] == "Distinct")
            {
                input = input.Distinct().ToArray();
            }
            else if (commands[0] == "Replace")
            {
                int indexToReplace = int.Parse(commands[1]);
                string stringToReplace = commands[2];
                input[indexToReplace] = stringToReplace;
            }
        }

        Console.WriteLine(string.Join(", ", input));
    }
}