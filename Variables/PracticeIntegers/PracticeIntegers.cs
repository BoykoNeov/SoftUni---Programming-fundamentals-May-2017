/// <summary>
/// Create a new C# project and create a program that assigns integer values to variables.
/// Be sure that each value is stored in
/// the correct variable type (try to find the most suitable variable type in order to save memory).
/// Finally, you need to print all variables to the console.
/// </summary>
using System;
public class ProgPracticeIntegers
{
    public static void Main()
    {
        sbyte shortByteNumber = -100;
        byte byteNumber = 128;
        short shortIntNumber = -3540;
        ushort unsignedShortNumber = 64876;
        uint unsignedIntegerNumber = 2147483648;
        int integerNumber = -1141583228;
        long longNumber = -1223372036854775808l;

        Console.WriteLine(shortByteNumber);
        Console.WriteLine(byteNumber);
        Console.WriteLine(shortIntNumber);
        Console.WriteLine(unsignedShortNumber);
        Console.WriteLine(unsignedIntegerNumber);
        Console.WriteLine(integerNumber);
        Console.WriteLine(longNumber);
    }
}