// Write a program that reads sequence of numbers and special bomb number with a certain power. Your task is to
// detonate every occurrence of the special bomb number and according to its power his neighbors from left and
// right.Detonations are performed from left to right and all detonated numbers disappear.Finally print the sum of
// the remaining elements in the sequence.

using System;
using System.Collections.Generic;
using System.Linq;

public class BombNumbers
{
    public static void Main()
    {
        List<int> inputList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

        List<int> bombNumberList = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        int bombNumber = bombNumberList[0];
        int bombPower = bombNumberList[1];

        for (int i = 0; i < inputList.Count; i++)
        {
            if (inputList[i] == bombNumber)
            {
                for (int j = 0; j <= bombPower && i < inputList.Count; j++)
                {
                    inputList.RemoveAt(i);
                }

                for (int k = 1; k <= bombPower && i-k >= 0; k++)
                {
                    inputList.RemoveAt(i - k);
                }
                // restart the search from the beginning
                i = -1;
            }

        }

        long sum = 0;
        foreach (int number in inputList)
        {
            sum += number;
        }

        Console.WriteLine(sum);
    }
}