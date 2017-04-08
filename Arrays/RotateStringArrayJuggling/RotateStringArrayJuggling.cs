// Program for rotating arrays using different Algorithms

using System;
using System.Linq;

public class RotateStringArrayJuggling
{
    public static void Main()
    {
        // Reads strings from the Console and converts them to an array
        // Console.WriteLine("Please enter array of strings (integers separated by spaces)");
        string[] stringArray = Console.ReadLine()
            .Split(new char[] { ' ', ';' , '!', ',','?','.','/', '\\' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        // Alternative syntaxis without Linq
        // var intArray = Array.ConvertAll(Console.ReadLine()
        //    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

        //Console.WriteLine("Enter the number of positions to be shifted");
        //Console.WriteLine("Enter positive number for right shift, negative for left");
        int d = int.Parse(Console.ReadLine()) % stringArray.Length;
        if (d < 0)
        {
            d = (d + stringArray.Length) % stringArray.Length;
        }

        if (d != 0)
        {
            SubsetRotate(stringArray, d);
        }

        Console.WriteLine(string.Join(" ", stringArray));
    }

    public static void SubsetRotate(string[] array, int d)
    {
        int arraySubsetsNumber = EuclidsAlgorithm(array.Length, d);
        for (int i = 0; i < arraySubsetsNumber; i++)
        {
            for (int k = 0; k < array.Length / arraySubsetsNumber; k++)
            {
                int positionBase = i;
                int positionSwitch = (i + (k * d) + d) % array.Length;
                if (positionSwitch == positionBase)
                {
                    break;
                }

                string temp = array[positionBase];
                array[positionBase] = array[positionSwitch];
                array[positionSwitch] = temp;
            }
        }
    }

    // Euclidian algorithm to determine the greatest common divisor
    public static int EuclidsAlgorithm(int m, int n)
    {
        m = m % n;
        if (m == 0)
        {
            return n;
        }
        else
        {
            return EuclidsAlgorithm(n, m);
        }
    }
}