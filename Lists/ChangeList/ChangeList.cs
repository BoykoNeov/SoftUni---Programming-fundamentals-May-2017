using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Write a program, which reads a list of integers from the console and receives commands, which manipulate the list.
/// Your program may receive the following commands:
/// Delete {element} – delete all elements in the array, which are equal to the given element
/// Insert {element} {position} – insert element and the given position
/// You should stop the program when you receive the command Odd or Even.If you receive Odd  print all odd
/// numbers in the array separated with single whitespace, otherwise print the even numbers.
/// </summary>
public class ChangeList
{
    public static void Main()
    {
        List<int> intList = new List<int>(Console.ReadLine().Split().Select(int.Parse));
        string command = string.Empty;

        while ((command = Console.ReadLine()) != "Odd" && command != "Even")
        {
            string[] commandArgs = command.Split();

            if (commandArgs.First() == "Delete")
            {
                intList.RemoveAll(x => x == int.Parse(commandArgs[1]));
            }

            if (commandArgs.First() == "Insert")
            {
                intList.Insert(int.Parse(commandArgs[2]), int.Parse(commandArgs[1]));
            }
        }

        Console.WriteLine(string.Join(" ", (command == "Even") ? intList.Where(x => x % 2 == 0) : intList.Where(x => x % 2 != 0)));
    }
}