using System;
using System.Linq;

/// <summary>
/// Write a program, which receives an array of integers and an integer as input. Find the last occurrence of the integer in the given array and print the sum of all elements before the number. 
/// Example: if we receive the array 10 20 30 40 20 30 40 and we receive on the next line the integer 20 we have to print the sum the elements 10 20 30 40, which is 100.
/// If no such number exists in the array – print “No occurrences were found!”.
/// Input
/// On the first line, you will receive the integer array
/// On the next line, you will receive the number, which you have to search
/// Output
/// If such number exists in the array – just print the sum.
/// Otherwise, print “No occurrences were found!”
/// Constraints
/// Only a single whitespace will be used for the separator.
/// The number will be integer in the interval [-2147483648…2147483647]
/// </summary>
public class GrabAndGo
{
    public static void Main()
    {
        long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long numberToSkip = long.Parse(Console.ReadLine());

        if (!input.Contains(numberToSkip))
        {
            Console.WriteLine("No occurrences were found!");
            return;
        }

        double result = input.Reverse().SkipWhile(x => x != numberToSkip).Sum() - numberToSkip;
        Console.WriteLine(result);
    }
}