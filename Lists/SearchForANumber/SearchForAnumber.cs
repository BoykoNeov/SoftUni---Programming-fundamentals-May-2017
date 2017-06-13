using System;
using System.Collections.Generic;
using System.Linq;

public class SearchForAnumber
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        var operators = Console.ReadLine().Split().Select(int.Parse).ToList();

        var numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();

        Console.WriteLine((numbers.Take(operators[0]).Skip(operators[1]).Contains(operators[2]) ? "YES!" : "NO!"));
    }
}