//Soft uni debugging excercise from Programing Fundamentals - Methods and debugging

using System;
using System.Linq;

/// <summary>
///
/// You are given a program that reads a ** n numbers** and a** sequence of commands** to be executed over these numbers.
/// - The first line holds an integer n – the count of numbers.
/// - The second line holds n numbers – integers separated by space.
/// - Each of the next few lines hold commands in format: “[action] [i-th element] [value]”.
/// - The commands sequence end with a command “stop”.
/// Commands are given in format**“[action] [i-th element] [value]”.** Elements are indexed from 1 to n.
/// The** action** can be **“multiply”, “add”, “subtract”, “rshift” or “lshift”.**
/// - The actions **“multiply”, “add”** and**“subtract”** have parameters. The first parameter is the** index** of the
/// element that needs to be changed (in range**[1...n]**). The second parameter is the value with which we
/// manipulate the element.
/// - The command **“lshift”** moves the first element last.E.g. **“lshift”** over { 1, 2, 3}
/// will produce {2, 3, 1}.
/// - The command **“rshift”** moves the last element first.E.g. **“rshift”** over { 1, 2, 3}
/// will produce {3, 1, 2}.
/// Print the values of the** n elements** after the execution of each command(except the last**“stop”** command).
/// - The** number n** will be an integer in the range[1 … 15].
/// - Each** element of the array** will be an integer in the range[0 … 2 63 - 1].
/// - The** number i** and the** number of commands** will be integers in the range[1 … 10].
///- The** number value** will be an integer in the range[-100 … 100]. If the command is **“rshift”** or **“lshift”** there
/// are no parameters.
/// </summary>
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
