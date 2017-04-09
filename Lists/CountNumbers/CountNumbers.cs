// Read a list of integers in range[0…1000] and print them in ascending order along with their number of occurrences.

using System;
using System.Collections.Generic;
using System.Linq;

public class CountNumbers
{
    public static void Main()
    {
        List<int> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        SortedDictionary<int, int> counts = new SortedDictionary<int, int>();

        foreach (int number in input)
        {
            int value;
            if (counts.TryGetValue(number, out value))
            {
                counts[number] = value + 1;
            }
            else
            {
                counts.Add(number, 1);
            }
        }
        foreach (KeyValuePair<int, int> kvp in counts)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}