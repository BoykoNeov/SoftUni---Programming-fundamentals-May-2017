using System;
using System.Linq;

/// <summary>
/// Write a program, which receives an array of integers (space-separated), removes all the odd numbers, then converts the remaining numbers to odd numbers, based on these conditions:
/// If the number is larger than the average of the collection of remaining numbers, add 1 to it.
/// If the number is smaller than the average of the collection of remaining numbers, subtract 1 from it.
/// After you convert all of the elements to odd numbers, print them on the console (space-separated).
/// </summary>
public class OddFilter
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .Where(x => x % 2 == 0);
        double average = numbers.Average();

        Console.WriteLine(string.Join(" ", numbers.Select(x => x > average ? x + 1 : x - 1)));
    }
}