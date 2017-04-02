using System;

public class HelloName
{
    public static void Main()
    {
        SayHello(Console.ReadLine());
    }

    public static void SayHello(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}