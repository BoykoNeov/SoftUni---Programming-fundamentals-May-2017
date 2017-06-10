using System;
using System.Linq;
/// <summary>
/// Write a program which receives array of integers (space-separated) and 
/// prints the minimum and maximum number, the sum of the elements and the average value.
/// </summary>
public class ArrayStatistics
{
    public static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine($"Min = {input.Min()}");
        Console.WriteLine($"Max = {input.Max()}");
        Console.WriteLine($"Sum = {input.Sum()}");
        Console.WriteLine($"Average = {input.Average()}");
    }
}