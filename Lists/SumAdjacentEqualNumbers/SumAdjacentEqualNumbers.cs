// Write a program to sum all adjacent equal numbers in a list of decimal numbers, starting from left to right.
// After two numbers are summed, the obtained result could be equal to some of its neighbors and should be
// summed as well (see the examples below).
// Always sum the leftmost two equal neighbors(if several couples of equal neighbors are available).

using System;
using System.Collections.Generic;
using System.Linq;

public class SumAdjacentEqualNumbers
{
    public static void Main()
    {
        List<decimal> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                numbers[i] = numbers[i] * 2;
                numbers.RemoveAt(i + 1);
                i = -1;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}