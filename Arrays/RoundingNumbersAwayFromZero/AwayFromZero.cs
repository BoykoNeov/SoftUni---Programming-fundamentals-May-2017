// Write a program to read an array of real numbers(space separated values), round them to the nearest integer in
// “away from 0” style and print the output as in the examples below.

using System;
using System.Linq;

public class AwayFromZero
{
    public static void Main()
    {
        decimal[] decimalArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();
        foreach (decimal number in decimalArray)
        {
            Console.WriteLine($"{number} => {Math.Round(number, MidpointRounding.AwayFromZero)}");
        }
    }
}