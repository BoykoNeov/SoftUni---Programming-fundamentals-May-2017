// Program for rotating arrays using different Algorithms

using System;
using System.Linq;

public class RotateArray
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
        int d = int.Parse(Console.ReadLine()) % intArray.Length;

        if (d != 0)
            SubsetRotation(intArray, d);

        Console.WriteLine(string.Join(" ", intArray));


    }

    public static void SubsetRotation(int[] array, int d)
    {
        int arraySubsetsNumber = EuclideanAlgorithm(array.Length, d);
        for (int i = 0; i < arraySubsetsNumber; i++)
        {
            if (arraySubsetsNumber > 1)
            {
                /////////////////////
            }
            else
            {
                d = Math.Abs(array.Length - d);
                for (int k = 0; k < array.Length; k++)
                {
                    int position = (k * d + d) % array.Length;
                    int temp = array[0];
                    array[0] = array[position];
                    array[position] = temp;
                }
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