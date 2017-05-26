/// <summary>
/// Problem 6.	Interval of Numbers
/// Write a program, which takes two numbers as input and prints the interval of numbers between them, starting from the smaller one and ending with the larger one.
/// Input
/// You will receive two lines.Each of them will contain one integer.
/// Output
/// Print all the numbers separated on new lines.
/// Constraints
/// The numbers, which you receive will be in the interval[0…100].
/// The two numbers, which you take as an input will not be equal
/// </summary>
using System;
class IntervalOfNumbers
{
    static void Main()
    {
        byte a = byte.Parse(Console.ReadLine());
        byte b = byte.Parse(Console.ReadLine());

        if (b < a)
        {
            byte temp = a;
            a = b;
            b = temp;
        }

        for (int i = a; i <= b; i++)
        {
            Console.WriteLine(i);
        }
    }
}