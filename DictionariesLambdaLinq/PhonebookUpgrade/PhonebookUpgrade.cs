using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Add functionality to the phonebook from the previous task to print all
/// contacts ordered lexicographically when receive the command “ListAll”.
/// </summary>
public class PhonebookUpgrade
{
    public static void Main()
    {
        string command = string.Empty;
        SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

        while (command != "END")
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();

            command = input[0];

            if (command == "A")
            {
                string value;
                bool phoneExists = phonebook.TryGetValue(input[1], out value);
                if (phoneExists == false)
                {
                    phonebook.Add(input[1], input[2]);
                }
                else
                {
                    phonebook[input[1]] = input[2];
                }
            }

            if (command == "S")
            {
                string value;
                bool phoneExists = phonebook.TryGetValue(input[1], out value);
                if (phoneExists == false)
                {
                    Console.WriteLine($"Contact {input[1]} does not exist.");
                }
                else
                {
                    Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                }
            }

            if (command == "ListAll")
            {
                foreach (KeyValuePair<string,string> kvp in phonebook)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}