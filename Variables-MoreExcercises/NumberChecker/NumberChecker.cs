/// <summary>
/// Write a program, which checks if a number is an integer or a floating-point number and prints either
/// “floating-point” or “integer”, depending on the case. You will only receive numbers.
/// </summary>
using System;

public class NumberChecker
{
    public static void Main()
    {
        long notNeeded;
        if (long.TryParse(Console.ReadLine(), out notNeeded))
        {
            Console.WriteLine("integer");
        }
        else
        {
            Console.WriteLine("floating-point");
        }
    }
}