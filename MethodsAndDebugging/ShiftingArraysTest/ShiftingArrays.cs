using System;

/// <summary>
/// Program for testing basic shifting arrays algorithms
/// </summary>
public class ShiftingArrays
{
    public static void Main()
    {
        // Create an initial array
        int[] originalArray = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

        //Reserve the initial array for further shifting experiments while creating a copy to be used for shifting
        int[] shiftedArray = new int[originalArray.Length];
        Array.Copy(originalArray, shiftedArray, originalArray.Length);

        //Shift array right one position
        for (int i = 0; i < shiftedArray.Length - 1; i++)
        {
            int temp = shiftedArray[i];
            shiftedArray[i] = shiftedArray[shiftedArray.Length - 1];
            shiftedArray[shiftedArray.Length - 1] = temp;
        }
        //Array is shifted right one position and result is displayed with the original array bellow
        Console.WriteLine("Shifted right one position: " + String.Join(", ", shiftedArray));
        Console.WriteLine("Original array:             " + String.Join(", ", originalArray) + Environment.NewLine);

        //Reset the array to the original
        Array.Copy(originalArray, shiftedArray, originalArray.Length);

        //Shift array left one position
        for (int i = 0; i < shiftedArray.Length - 1; i++)
        {
            int temp = shiftedArray[0];
            shiftedArray[0] = shiftedArray[shiftedArray.Length - 1 - i];
            shiftedArray[shiftedArray.Length - 1 - i] = temp;
        }

        //Array is shifter left one position and result is displayed with the original array bellow
        Console.WriteLine("Shifted left one position:  " + String.Join(", ", shiftedArray));
        Console.WriteLine("Original array:             " + String.Join(", ", originalArray) + Environment.NewLine);

        //Reset the array to the original
        Array.Copy(originalArray, shiftedArray, originalArray.Length);

        int k = 1;

        //Shift left k times using an additional array (in this case the two arrays are the original array and the "shifted array"
        for (int i = 0; i < originalArray.Length; i++)
        {
            shiftedArray[i] = originalArray[(i + k) % originalArray.Length];
        }
        Console.WriteLine("Shifted left \"k\" position(s): " + String.Join(", ", shiftedArray));

        //Shift right k times using an additional array (in this case the two arrays are the original array and the "shifted array"
        for (int i = 0; i < originalArray.Length; i++)
        {
            shiftedArray[(i + k) % originalArray.Length] = originalArray[i];
        }
        Console.WriteLine("Shifted right \"k\" position(s): " + String.Join(", ", shiftedArray));

        //Shift right k times using an additional array (in this case the two arrays are the original array and the "shifted array"
        for (int i = 0; i < originalArray.Length; i++)
        {
            shiftedArray[i] = originalArray[(i - k + originalArray.Length) % originalArray.Length];
        }
        Console.WriteLine("Shifted right \"k\" position(s): " + String.Join(", ", shiftedArray));

    }
}