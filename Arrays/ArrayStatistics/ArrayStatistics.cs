using System;
using System.Linq;

    public class ArrayStatistics
    {
        public static void Main()
        {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(input.Min());
        }
    }