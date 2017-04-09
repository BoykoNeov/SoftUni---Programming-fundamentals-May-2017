// Read a list of decimal numbers and sort them in increasing order. Print the output

using System;
using System.Collections.Generic;
using System.Linq;

class SortNumbers
{
    public static void Main()
    {
        List<decimal> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();
        numbers.Sort();
        Console.WriteLine(string.Join(" <= ", numbers));
    }
}