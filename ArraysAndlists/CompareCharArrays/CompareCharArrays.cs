// Compare two char arrays lexicographically (letter by letter).
// Print the them in alphabetical order, each on separate line.

using System;
using System.Linq;

public class CompareCharArrays
{
    public static void Main()
    {
        char[] arrayA = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(char.Parse)
            .ToArray();
        char[] arrayB = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(char.Parse)
            .ToArray();
        bool resultPrinted = false;

        for (int i = 0; i < arrayA.Length && i < arrayB.Length; i++)
        {
            if (arrayA[i] < arrayB[i])
            {
                Print(arrayA , arrayB);
                resultPrinted = true;
                break;
            }
            else if (arrayA[i] > arrayB[i])
            {
                Print(arrayB, arrayA);
                resultPrinted = true;
                break;
            }
        }
        if (resultPrinted == false)
        {
            if (arrayA.Length <= arrayB.Length)
            {
                Print(arrayA, arrayB);
            }
            else
            {
                Print(arrayB, arrayA);
            }
        }
    }
    
    public static void Print(char[] charArray, char[] secondCharArray)
    {
        Console.WriteLine(string.Join("", charArray));
        Console.WriteLine(string.Join("", secondCharArray));
    }
}