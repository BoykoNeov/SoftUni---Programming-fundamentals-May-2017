using System;
using System.Linq;
/// <summary>
/// Write a method that prints the digits of a given decimal number in a reversed order.
/// </summary>
public class NumbersInReversedOrder
{
    public static void Main()
    {
        Console.WriteLine(string.Join("",Console.ReadLine().Reverse()));
    }
}