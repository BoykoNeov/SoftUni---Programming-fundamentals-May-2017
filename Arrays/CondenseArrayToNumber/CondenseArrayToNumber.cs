// Write a program to read an array of integers and condense them by summing adjacent couples of elements until a
// single integer is obtained.For example, if we have 3 elements {2, 10, 3}, we sum the first two and the second two
// elements and obtain {2+10, 10+3} = { 12, 13 }, then we sum again all adjacent elements and obtain {12+13} = {25}.

using System;
using System.Linq;

public class CondenseArrayToNumber
{
    public static void Main()
    {
        int[] intArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        while (intArray.Length > 1)
        {
            int[] condensedArray = new int[intArray.Length - 1];
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                condensedArray[i] = intArray[i] + intArray[i + 1];
            }
            intArray = condensedArray;
        }

        Console.WriteLine(intArray[0]);
    }
}