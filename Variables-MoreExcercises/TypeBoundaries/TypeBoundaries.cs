using System;
/// <summary>
/// Write a program which receives a number type (as a string) and prints the maximum and the
/// minimum value of that type. You can receive one of the following types: “int”, “uint”, “long”, “byte” and “sbyte”.
/// </summary>
public class TypeBoundaries
{
    public static void Main()
    {
        string input = Console.ReadLine();
        if (input == "byte")
        {
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
        }

        if (input == "int")
        {
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
        }

        if (input == "uint")
        {
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(uint.MinValue);
        }

        if (input == "long")
        {
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
        }

        if (input == "sbyte")
        {
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);
        }
    }
}