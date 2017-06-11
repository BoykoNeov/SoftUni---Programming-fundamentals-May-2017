using System;
using System.Linq;

/// <summary>
/// You will receive an integer array from the console. You start from the beginning 
/// of the array and try to move right by a step, equal to the value at position 0. 
/// If that is possible you should collect the value from the index on which you landed,
/// and try to move to the right by its value, 
/// if that is not possible – try to move to the left. If that is also not possible stop
/// the program and print the sum of the collected values.
/// </summary>
public class JumpAround
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.None)
            .Select(int.Parse)
            .ToArray();

        long totalSum = 0;
        int currentIndex = 0;
        bool withinArray = true;

        while (withinArray)
        {
            int currentNumber = numbers[currentIndex];
            totalSum += currentNumber;

            if ((currentIndex + currentNumber) > (numbers.Length - 1))
            {
                if ((currentIndex - currentNumber) < 0)
                {
                    withinArray = false;
                }
                else
                {
                    currentIndex -= currentNumber;
                }
            }
            else
            {
                currentIndex += currentNumber;
            }
        }

        Console.WriteLine(totalSum);
    }
}