// Write a program that count the number of pairs in given array which difference is equal to given number.

using System;
using System.Linq;

public class PairsByDifference
{
    public static void Main()
    {
        int[] intArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int difference = int.Parse(Console.ReadLine());
        int pairsCount = 0;

        for (int i = 0; i < intArray.Length; i++)
        {
            for (int j = i+1; j < intArray.Length; j++)
            {
                if (Math.Abs(intArray[i] - intArray[j]) == difference)
                {
                    pairsCount++;
                }
            }
        }
        Console.WriteLine(pairsCount);
    }
}