// Write a program that finds the longest sequence of equal elements in an array of integers.
// If several longest sequences exist, print the leftmost one.

using System;
using System.Linq;

public class MaxSequenceEqualElements
{
    public static void Main()
    {
        string[] sequence = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        int bestStart = 0;
        int bestLength = 1;
        int start = 0;
        int length = 1;

        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] == sequence[i-1])
            {
                length++;
                if (length > bestLength)
                {
                    bestLength = length;
                    bestStart = start;
                }
            }
            else
            {
                length = 1;
                start = i;
            }
        }
        Console.WriteLine(string.Join(" ", sequence, bestStart, bestLength));
    }
}