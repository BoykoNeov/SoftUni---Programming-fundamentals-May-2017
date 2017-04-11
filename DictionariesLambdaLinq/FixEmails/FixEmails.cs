// You are given a sequence of strings, each on a new line, until you receive the “stop” command.
// The first string is the name of a person.On the second line you will receive their email.
// Your task is to collect their names and emails, and remove emails whose domain ends with "us" or "uk" (case insensitive).
// Print: {name} – > {email} 

using System;
using System.Collections.Generic;

public class FixEmails
{
    public static void Main()
    {
        Dictionary<string, string> resources = new Dictionary<string, string>();

        while (true)
        {
            string evenInput;
            evenInput = Console.ReadLine();

            if (evenInput == "stop")
            {
                break;
            }

            string oddInput = Console.ReadLine();

            string value;
            if (resources.TryGetValue(evenInput, out value))
            {
                resources[evenInput] = oddInput;
            }
            else
            {
                resources.Add(evenInput, oddInput);
            }

        }

        foreach (var kvp in resources)
        {
            string key = kvp.Key;
            if (!(key[key.Length - 2] == 'u'))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}