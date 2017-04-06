// Read two arrays of words and find the length of the largest common end (left or right).
using System;
using System.Linq;

public class GreatestEnd
{
    public static void Main()
    {
        var firstString = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions
            .RemoveEmptyEntries)
            .ToArray();
        var secondString = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions
            .RemoveEmptyEntries)
            .ToArray();

        // the common elements can't be bigger than any of the arrays , so this array can be as big as any of the two arrays
        string[] beginningCommonEnd = new string[firstString.Length];

        // search the strings from beginning to end for a common end and the beginning
        for (int i = 0; i < firstString.Length && i < secondString.Length; i++)
        {
            if (firstString[i] == secondString[i])
            {
                beginningCommonEnd[i] = firstString[i];
            }
            else
            {
                break;
            }
        }

        // since the string[] was defined as probably bigger than the answer will be, remove empty entries in order to properly determine its length
        beginningCommonEnd = beginningCommonEnd.Where(x => !string.IsNullOrEmpty(x)).ToArray();

        // define the back end and search the strings[] from end to beginning
        string[] endingCommonEnd = new string[firstString.Length];
        for (int j = 0; j < firstString.Length && j < secondString.Length; j++)
        {
            if (firstString[firstString.Length - 1 - j] == secondString[secondString.Length - 1 - j])
            {
                endingCommonEnd[firstString.Length - 1 - j] = secondString[secondString.Length - 1 - j];
            }
            else
            {
                break;
            }
        }

        // as with the other end, remove the empty entries in order to properly determine the length
        endingCommonEnd = endingCommonEnd.Where(x => !string.IsNullOrEmpty(x)).ToArray();

        // compare the two and display the length of the bigger
        if (endingCommonEnd.Length > beginningCommonEnd.Length)
        {
            beginningCommonEnd = endingCommonEnd;
        }

        Console.WriteLine(beginningCommonEnd.Length);
    }
}