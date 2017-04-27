// Write a program that reads a string from the console, reverses it and prints the result back at the console.

using System;
using System.Linq;

public class ReverseString
{
    public static void Main()
    {
        Console.WriteLine(string.Join(string.Empty, Console.ReadLine().Reverse()));
    }
}