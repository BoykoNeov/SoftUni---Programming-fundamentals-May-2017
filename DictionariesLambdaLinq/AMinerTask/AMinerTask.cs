// You are given a sequence of strings, each on a new line.Every odd line on the console is representing a resource(e.g.Gold, Silver, Copper, and so on), and every even – quantity.Your task is to collect the resources and print them each on a new line.
// Print the resources and their quantities in format:
// {resource} –> {quantity}
// The quantities inputs will be in the range[1 … 2 000 000 000]

using System;
using System.Collections.Generic;

public class AMinerTask
{
    public static void Main()
    {
        Dictionary<string, long> resources = new Dictionary<string, long>();

        while (true)
        {
            string evenInput;
            evenInput = Console.ReadLine();

            if (evenInput == "stop")
            {
                break;
            }

            long oddInput = long.Parse(Console.ReadLine());

            long value;
            if (resources.TryGetValue(evenInput, out value))
            {
                resources[evenInput] = value + oddInput;
            }
            else
            {
                resources.Add(evenInput, oddInput);
            }

        }

        foreach (var kvp in resources)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}