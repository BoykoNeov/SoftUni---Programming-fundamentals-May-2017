// Write a program that receives some info from the console about people and their phone numbers.Each entry
// should have just one name and one number (both of them strings).
// On each line you will receive some of the following commands:
// A {name} {phone} – adds entry to the phonebook.In case of trying to add a name that is already in the
// phonebook you should change the existing phone number with the new one provided.
// S { name} – searches for a contact by given name and prints it in format {name} -> {number}. In case
// the contact isn&#39;t found, print &quot;Contact {name} does not exist.&quot;.
// END – stop receiving more commands.

using System;
using System.Collections.Generic;
using System.Linq;

public class Phonebook
{
    public static void Main()
    {
        string command = string.Empty;
        Dictionary<string, string> phonebook = new Dictionary<string, string>();

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
        }
    }
}