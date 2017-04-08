using System;
using System.Collections.Generic;
using System.Linq;

public class TripleSum
{
    public static void Main()
    {
        int[] intArray = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        bool resultFound = false;

        for (int i = 0; i < intArray.Length; i++)
        {
            for (int j = i + 1; j < intArray.Length; j++)
            {
                for (int k = 0; k < intArray.Length; k++)
                {
                    if (intArray[i] + intArray[j] == intArray[k])
                    {
                        Console.WriteLine($"{intArray[i]} + {intArray[j]} == {intArray[k]}");
                        resultFound = true;
                        break;
                    }
                }
            }
        }

        if (!resultFound)
        {
            Console.WriteLine("No");
        }
    }
}