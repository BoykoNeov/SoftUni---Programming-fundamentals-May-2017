using System;
using System.Linq;

public class SumReversedNumbers
{
    public static void Main()
    {
        Console.WriteLine(new string(Console.ReadLine().Reverse().ToArray()).Split().Select(int.Parse).Sum());
    }
}