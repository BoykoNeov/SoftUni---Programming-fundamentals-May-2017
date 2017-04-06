// Write a program that finds the most frequent number in a given sequence of numbers.
// In case of multiple numbers with the same maximal frequency, print the leftmost of them.

using System;
using System.Collections.Generic;
using System.Linq;

public class MostFrequentNumber
{
    public static void Main()
    {
        int[] intArray = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        Dictionary<int, int> dictCount = new Dictionary<int, int>();
        int maxCount = 1;

        foreach (int number in intArray)
        {
            int count;
            if (dictCount.TryGetValue(number, out count))
            {
                dictCount[number] = count + 1;
                if (maxCount < count + 1)
                {
                    maxCount = count + 1;
                }
            }
            else
            {
                dictCount.Add(number, 1);
            }
        }

        for (int i = 0; i < intArray.Length; i++)
        {

        }
        foreach (int number in intArray)
        {
            if (dictCount[number] == maxCount)
            {
                Console.WriteLine(number);
                break;
            }
        }
    }
}