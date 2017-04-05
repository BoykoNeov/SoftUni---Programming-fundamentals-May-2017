// Write a program to read an array of n integers (space separated on a single line) and an integer k,
// rotate the array right k times and sum the obtained arrays after each rotation

using System;
using System.Linq;

public class RotateAndSum
{
    public static void Main()
    {
        int[] array = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rotationCount = int.Parse(Console.ReadLine());
        int[] rotatedArray = new int[array.Length];
        int[] sumArray = new int[array.Length];

        for (int j = 0; j < rotationCount; j++)
        {
            for (int i = 0; i < array.Length; i++)
            {
                rotatedArray[(i + 1) % array.Length] = array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rotatedArray[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                sumArray[i] += rotatedArray[i];
            }
        }

        Console.WriteLine(string.Join(" ", sumArray));
    }
}