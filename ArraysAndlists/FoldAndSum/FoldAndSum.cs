// Read an array of 4*k integers, fold it (first 1/4 and last 1/4 form a new array (each side reversed),
// and print the sum of the upper and lower two rows (each holding 2 * k integers)

using System;
using System.Linq;

public class FoldAndSum
{
    public static void Main()
    {
        // read the numbers and split them into an array
        int[] initialArray = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int[] upperArray = new int[initialArray.Length / 2];
        int[] lowerArray = new int[initialArray.Length / 2];

        // define a tempArray, for the formation of the upper array
        int[] tempArray = new int[initialArray.Length / 4];
        Array.Copy(initialArray, 0, tempArray, 0, initialArray.Length / 4);
        Array.Reverse(tempArray);

        // the next two "for" cycles fill the upper array
        for (int i = 0; i < tempArray.Length; i++)
        {
            upperArray[i] = tempArray[i];
        }

        Array.Copy(initialArray, (initialArray.Length / 4) * 3, tempArray, 0, initialArray.Length / 4);
        Array.Reverse(tempArray);

        for (int i = 0; i < tempArray.Length; i++)
        {
            upperArray[(upperArray.Length / 2) + i] = tempArray[i];
        }

        // sum the two arrays and display the result
        Array.Copy(initialArray, initialArray.Length / 4, lowerArray, 0, lowerArray.Length);

        for (int i = 0; i < lowerArray.Length; i++)
        {
            lowerArray[i] += upperArray[i];
        }

        Console.WriteLine(string.Join(" ", lowerArray));
    }
}