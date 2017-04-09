// Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order. In
// case of no elements left in the list, print “empty”.

using System;
using System.Collections.Generic;
using System.Linq;

public class RemoveNegativesAndReverse
{
    public static void Main()
    {
        List<int> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        List<int> output = new List<int>();
        for (int i = 0; i < input.Count; i++)
        {
            if (input[i] > 0)
            {
                output.Add(input[i]);
            }
        }
        output.Reverse();
        if (output.Count != 0)
        {
            Console.WriteLine(string.Join(" ", output));
        }
        else
        {
            Console.WriteLine("empty");
        }
    }
}