using System;

/// <summary>
/// The program accepts two integers on two lines and calculates the greates common divisor using Euclidean Algorithm and Recursion
/// The process of data entry is repeated until a valid integer is entered.
/// </summary>
public class Euclidean
{
    public static void Main()
    {
        Console.WriteLine("The program calculates the greates common divisor of two integers.");
        Console.WriteLine("Please enter the first integer!");
        int m = ValueEntry();
        Console.WriteLine("Please enter the second integer!");
        int n = ValueEntry();
        int result = 0;
        if (m >= n)
        {
            result = EuclideanAlgorithm(m, n);
        }
        else
        {
            result = EuclideanAlgorithm(n, m);
        }

        Console.WriteLine($"The greates common divisor of {m} and {n} is {result}");
    }

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

    public static int ValueEntry()
    {
        if (!int.TryParse(Console.ReadLine(), out int returnValue))
        {
            Console.WriteLine("Please enter an integer!");
            returnValue = ValueEntry();
        }

        if (returnValue == 0)
        {
            Console.WriteLine("Please enter a non zero value!");
            return ValueEntry();
        }
        return returnValue;
    }
}