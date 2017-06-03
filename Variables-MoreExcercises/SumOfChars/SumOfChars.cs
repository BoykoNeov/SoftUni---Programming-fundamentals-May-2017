/// <summary>
/// Write a program, which sums the ASCII codes of n characters and prints the sum on the console.
/// </summary>
using System;

public class SumOfChars
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int charSum = 0;

        for (int i = 0; i < n; i++)
        {
            charSum += Console.Read();
            Console.ReadLine();
        }

        Console.WriteLine($"The sum equals: {charSum}");
    }
}