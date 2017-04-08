// Write a program that finds the longest increasing subsequence in an array of integers.
// The longest increasing subsequence is a portion of the array (subsequence) that is strongly increasing and has the longest possible length.
// If several such subsequences exist, find the left most of them.

using System;
using System.Linq;

public class MaxSequenceIncreasingElements
{
    public static void Main()
    {
        int[] sequence = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int bestStart = 0;
        int bestLength = 1;
        int start = 0;
        int length = 1;

        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] > sequence[i - 1])
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

        Console.WriteLine(string.Join(" ", (sequence
            .Select(x =>x.ToString())
            .ToArray()), bestStart, bestLength));
    }
}