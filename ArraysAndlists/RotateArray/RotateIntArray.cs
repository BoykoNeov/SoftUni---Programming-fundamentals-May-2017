// Program for rotating arrays using different Algorithms

using System;
using System.Linq;

public class RotateIntArray
{
    public static void Main()
    {
        // Reads ints from the Console and converts them to an array of ints
        Console.WriteLine("Please enter array of integers (integers separated by spaces)");
        var intArray = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        // Alternative syntaxis without Linq
        //var intArray = Array.ConvertAll(Console.ReadLine()
        //    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

        Console.WriteLine("Enter the number of positions to be shifted");
        Console.WriteLine("Enter positive number for right shift, negative for left");
        int d = int.Parse(Console.ReadLine()) % intArray.Length;
        if (d < 0)
        {
            d = (d + intArray.Length) % intArray.Length;
        }

        if (d != 0)
        {
            SubsetRotation(intArray, d);
        }

        Console.WriteLine(string.Join(" ", intArray));
    }

    public static void SubsetRotation(int[] array, int d)
    {
        int arraySubsetsNumber = EuclideanAlgorithm(array.Length, d);
        for (int i = 0; i < arraySubsetsNumber; i++)
        {
            for (int k = 0; k < array.Length / arraySubsetsNumber; k++)
            {
                int positionBase = (i);
                int positionSwitch = ((i + k * d + d) % array.Length);
                if (positionSwitch == positionBase)
                {
                    break;
                }
                int temp = array[positionBase];
                array[positionBase] = array[positionSwitch];
                array[positionSwitch] = temp;
            }
        }
    }
    //Euclidian algorithm to determine the greatest common divisor
    public static int EuclideanAlgorithm(int m, int n)
    {
        m = m % n;
        if (m == 0)
        {
            return n;
        }
        else
        {
            return EuclideanAlgorithm(n, m);
        }
    }
}