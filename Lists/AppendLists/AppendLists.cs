// Write a program to append several lists of numbers.
// Lists are separated by ‘|’.
// Values are separated by spaces(‘ ’, one or several)
// Order the lists from the last to the first, and their values from left to right.

using System;
using System.Collections.Generic;
using System.Linq;


public class AppendLists
{
    public static void Main()
    {
        List<string> inputs = Console.ReadLine()
            .Split(new char[] { '|' }, StringSplitOptions
            .RemoveEmptyEntries)
            .ToList();
        List<int> outputs = new List<int>();

        for (int i = inputs.Count - 1; i >= 0; i--)
        {
            outputs.AddRange(inputs[i]
                .Split(new char[] { ' ' }, StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse));
        }

        Console.WriteLine(string.Join(" ", outputs));
    }
}