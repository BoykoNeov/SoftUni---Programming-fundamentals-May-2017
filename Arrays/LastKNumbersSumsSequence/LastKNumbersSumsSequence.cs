// Enter two integers n and k.Generate and print the following sequence of n elements:
// The first element is: 1
//  All other elements = sum of the previous k elements (if less than k are available, sum all of them)

using System;

public class LastKNumbersSumsSequence
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        long[] sequence = new long[n];
        sequence[0] = 1;
        for (int i = 1; i < sequence.Length; i++)
        {
            for (int j = i - 1, j2 = 1; j >= 0 && j2 <= k; j--, j2++)
            {
                sequence[i] += sequence[j];
            }
        }

        Console.WriteLine(string.Join(" ", sequence));
    }
}