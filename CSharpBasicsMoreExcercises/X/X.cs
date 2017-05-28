/// <summary>
/// Problem 1.	X
/// Write a program, which prints an X figure with height n.
/// N will be an odd number in the range [3…99].
/// </summary>
using System;

public class X
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char character = 'x';

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (row == col || row + col == size - 1)
                {
                    Console.Write(character);
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine(string.Empty);
        }
    }
}