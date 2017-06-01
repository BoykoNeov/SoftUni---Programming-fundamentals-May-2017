/// <summary>
/// Create a new C# project and create a program that assigns floating point values to variables. Be sure that each value is stored in the correct 
/// variable type (try to find the most suitable variable type in order to save memory). Finally, you need to print all variables to the console.
/// </summary>
using System;

public class PracticeFloatingPoints
{
    public static void Main()
    {
        decimal firstDecimalNumber = 3.141592653589793238m;
        double doubleNumber = 1.60217657d;
        decimal secondDecimalNumber = 7.8184261974584555216535342341m;

        Console.WriteLine(firstDecimalNumber);
        Console.WriteLine(doubleNumber);
        Console.WriteLine(secondDecimalNumber);
    }
}