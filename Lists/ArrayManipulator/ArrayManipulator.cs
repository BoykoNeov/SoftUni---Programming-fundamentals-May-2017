// Write a program that reads an array of integers from the console and set of commands and executes them over
// the array. The commands are as follows:
// add index element – adds element at the specified index (elements right from this position inclusively
// are shifted to the right).
// addMany index element1 element2 elementN – adds a set of elements at the specified index.
// contains element – prints the index of the first occurrence of the specified element (if exists) in the array
// or -1 if the element is not found.
// remove index – removes the element at the specified index.
// shift positions – shifts every element of the array the number of positions to the left (with rotation).
// sumPairs – sums the elements in the array by pairs (first + second, third + fourth, …).
// print – stop receiving more commands and print the last state of the array.

using System;
using System.Collections.Generic;
using System.Linq;

public class ArrayManipulator
{
    public static void Main()
    {
        List<int> inputList = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        int counterGarbaceCollector = 0;
        while (true)
        {
            // Only with the bellow code it passes the last judge test!
            counterGarbaceCollector++;
            if (counterGarbaceCollector > 1000)
            {
                GC.Collect();
                counterGarbaceCollector = 0;
            }

            List<string> inputCommands = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions
            .RemoveEmptyEntries)
            .ToList();

            string command = inputCommands[0];

            List<int> parameters = new List<int>();
            for (int i = 1; i < inputCommands.Count; i++)
            {
                parameters.Add(int.Parse(inputCommands[i]));
            }


            if (command == "print")
            {
                break;
            }

            switch (command)
            {
                case "add":
                    inputList.Insert(parameters[0], parameters[1]);
                    break;

                case "addMany":
                    int position = parameters[0];
                    parameters.RemoveAt(0);
                    inputList.InsertRange(position, parameters);
                    break;

                case "contains":
                    Console.WriteLine(inputList.IndexOf(parameters[0]));
                    break;

                case "remove":
                    inputList.RemoveAt(parameters[0]);
                    break;

                case "shift":
                    int shiftAmmount = parameters[0] % inputList.Count;
                    for (int i = 0; i < shiftAmmount; i++)
                    {
                        int temp = inputList[0];
                        inputList.RemoveAt(0);
                        inputList.Add(temp);
                    }
                    break;

                case "sumPairs":
                    for (int i = 0; i < inputList.Count-1; i++)
                    {
                        inputList[i] = inputList[i] + inputList[i + 1];
                        inputList.RemoveAt(i + 1);
                    }
                    break;

                default:
                    break;

            }
        }

        Console.WriteLine($"[{ string.Join(", ", inputList)}]");
    }
}