//Soft uni debugging excercise from Programing Fundamentals - Methods and debugging

using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Trim()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = string.Empty;

        while (!command.Equals("stop"))
        {
            string[] line = Console.ReadLine().Trim().Split(ArgumentsDelimiter);
            int[] args = new int[2];
            command = line[0];
            if (command == "stop")
            {
                break;
            }

            if (command.Equals("add") ||
                command.Equals("subtract") ||
                command.Equals("multiply"))
            {
                args[0] = int.Parse(line[1]);
                args[1] = int.Parse(line[2]);
            }

            PerformAction(array, command, args);
            PrintArray(array);
            Console.WriteLine();
        }
    }

    static void PerformAction(long[] arr, string action, int[] args)
    {
        int pos = args[0]-1;
        int value = args[1];

        switch (action)
        {
            case "multiply":
                arr[pos] *= value;
                break;
            case "add":
                arr[pos] += value;
                break;
            case "subtract":
                arr[pos] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(arr);
                break;
            case "rshift":
                ArrayShiftRight(arr);
                break;
        }
    }

    private static void ArrayShiftRight(long[] array)
    {
        long[] tempArray = new long[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            tempArray[(i + 1) % array.Length] = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = tempArray[i];
        }
    }

    private static void ArrayShiftLeft(long[] array)
    {
        long[] tempArray = new long[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            tempArray[i] = array[(i + 1) % array.Length];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = tempArray[i];
        }
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
