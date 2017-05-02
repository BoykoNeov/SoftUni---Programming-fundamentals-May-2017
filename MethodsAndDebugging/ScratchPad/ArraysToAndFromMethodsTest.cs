using System;

/// <summary>
/// Testing passing arrays to methods and returning arrays from methods
/// </summary>
public class ArraysToAndFromMethodsTest
{
    public static void Main()
    {
        int[] arrayToMethod = new int[] { 1, 2, 3 };
        int[] arrayFromMethod = ArraysMethod(arrayToMethod);
        foreach (int number in arrayFromMethod)
        {
            Console.WriteLine(number);
        }
    }

    public static int[] ArraysMethod(int[] arr)
    {
        int a = arr[0] + 10;
        int b = arr[1] + 20;
        int c = arr[2] + 30;
        int[] internalArr = new int[] { a, b, c };
        return internalArr;
    }
}