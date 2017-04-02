// Playing around with methods and arrays
using System;

public class ExperimentsWithArraysAndMethods
{
    public static void Main()
    {
        int[] mainArray = { 1, 2, 3 };
        ArrayMethod(mainArray);
        Console.WriteLine(mainArray[0]);
    }

    public static void ArrayMethod(int[] methodArray)
    {
        methodArray[0] = 5;
    }
   
}
