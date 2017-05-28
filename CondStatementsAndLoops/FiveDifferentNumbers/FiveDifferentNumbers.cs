/// <summary>
/// Problem 11.	5 Different Numbers
/// You will be given two numbers – a and b.Generate five numbers - n1, n2, n3, n4, n5, for which the following conditions 
/// are true: a ≤ n1&lt;n2&lt;n3&lt;n4 &lt; = n5 &lt; = b.If there is no number in the given interval, which satisfies the conditions – print “No!”.
/// Input
/// The input contains two integers, each on a new line.
/// Output
/// Print all numbers in increasing order and on a new line.
/// Constraints
/// a and b will be integers in the interval[-100…100]
/// </summary>
using System;

class FiveDifferentNumbers
{
    public static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        bool resultExists = false;

        for (int i1 = firstNumber; i1 < secondNumber - 3; i1++)
        {
            for (int i2 = i1 + 1; i2 < secondNumber - 2; i2++)
            {
                for (int i3 = i2 + 1; i3 < secondNumber - 1; i3++)
                {
                    for (int i4 = i3 + 1; i4  < secondNumber; i4 ++)
                    {
                        for (int i5 = i4 + 1; i5 <= secondNumber; i5++)
                        {
                            Console.WriteLine($"{i1} {i2} {i3} {i4} {i5}");
                            resultExists = true;
                        }
                    }
                }
            }
        }

        if (!resultExists)
        {
            Console.WriteLine("No");
        }
    }
}