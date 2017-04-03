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

       

    }
}