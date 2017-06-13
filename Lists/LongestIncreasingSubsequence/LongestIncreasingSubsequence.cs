using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Read a list of integers and find the longest increasing subsequence (LIS). If several such exist, print the leftmost.
/// </summary>
public class LongestIncreasingSubsequence
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int[] length = new int[numbers.Count];
        int[] previous = new int[numbers.Count];

        int maxLength = 0;
        int lastIndex = -1;

        for (int i = 0; i < numbers.Count; i++)
        {
            length[i] = 1;
            previous[i] = -1;
            for (int j = 0; j <= i; j++)
            {
                if (numbers[j] < numbers[i] && length[j] + 1 > length[i])
                {
                    length[i] = length[j] + 1;
                    previous[i] = j;
                }

                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }
        }

        List<int> longestSubsequence = new List<int>();

        while (lastIndex != -1)
        {
            longestSubsequence.Add(numbers[lastIndex]);
            lastIndex = previous[lastIndex];
        }

        longestSubsequence.Reverse();
        Console.WriteLine(string.Join(" ", longestSubsequence));
    }
}