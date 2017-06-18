using System;
using System.Linq;
/// <summary>
/// Write a program, which receives a list of times (space-separated, 24-hour format) and sorts
/// them in ascending order. Print the sorted times comma-separated.
/// Example: 06:55, 02:30, 23:11  02:30, 06:55, 21:11
/// </summary>
public class SortTimes
{
    public static void Main()
    {
        Console.WriteLine(string.Join(", ", Console.ReadLine().Split().OrderBy(x => x[0]).ThenBy(x => x[1]).ThenBy(x => x[3]).ThenBy(x => x[4])));
    }
}