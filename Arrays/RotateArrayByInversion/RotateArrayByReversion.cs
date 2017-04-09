// Rotate an array by reversion
// Algorithm - 1.Reverse the entire array 2.Reverse the first d-elements 3.Reverse the other half

using System;
using System.Linq;

public class RotateArrayByReversion
{
    public static void Main()
    {
        string[] ReversionArray = Console.ReadLine()
            .Split(new char[] { ' ', ';', '!', ',', '?', '.', '/', '\\' }, StringSplitOptions.
            RemoveEmptyEntries).
            ToArray();

        int d = int.Parse(Console.ReadLine()) % ReversionArray.Length;

        Array.Reverse(ReversionArray);
        Array.Reverse(ReversionArray, 0, d);
        Array.Reverse(ReversionArray, d, ReversionArray.Length -d);
        Console.WriteLine(string.Join(" ", ReversionArray));
    }
}