// Write a program that determines if there exists an element in the array such that the sum of the elements
// on its left is equal to the sum of the elements on its right.
// If there are no elements to the left / right, their sum is considered to be 0. 
// Print the index that satisfies the required condition or “no” if there is no such index.

using System;
using System.Linq;

public class EqualSums
{
    public static void Main()
    {
        int[] intArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

        for (int i = 0; i < intArray.Length; i++)
        {
            int leftSum = 0;
            int RightSum = 0;
            for (int leftIndex = 0; leftIndex < i; leftIndex++)
            {
                leftSum += intArray[leftIndex];
            }
            for (int rightIndex = intArray.Length - 1; rightIndex > i; rightIndex--)
            {
                RightSum += intArray[rightIndex];
            }
            if (leftSum == RightSum)
            {
                Console.WriteLine(i);
                return;
            }
        }
        Console.WriteLine("no");
    }
}