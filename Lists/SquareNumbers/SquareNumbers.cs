// Read a list of integers and extract all square numbers from it and print them in descending order. A square number
// is an integer which is the square of any integer.For example, 1, 4, 9, 16 are square numbers.

using System;
using System.Collections.Generic;
using System.Linq;

public class SquareNumbers
{
    public static void Main()
    {
        List<double> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
        for (int i = 0; i < numbers.Count; i++)
        {
            if (Math.Sqrt(numbers[i]) != (int)Math.Sqrt(numbers[i]))
            {
                numbers.Remove(numbers[i]);
                i--;
            }
        }
        numbers.Sort((a, b) => b.CompareTo(a));
        Console.WriteLine(string.Join (" ", numbers));
    }
}