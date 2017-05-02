using System;

/// <summary>
/// Displays "Hello and read name from the console using a custom function"
/// </summary>
public class HelloName
{
    public static void Main()
    {
        SayHello(Console.ReadLine());
    }

    /// <summary>
    /// displays input string to the console
    /// </summary>
    /// <param name="name">Input string to display</param>
    public static void SayHello(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}