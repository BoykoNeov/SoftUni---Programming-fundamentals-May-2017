using System;
using System.Numerics;

/// <summary>
/// Calculate a Fibonacci sequence n-th number
/// </summary>
public class FibonacciNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger result = 0;

        Console.WriteLine(NonRecursiveFibonacciCalculator(n));


    }

    public static BigInteger NonRecursiveFibonacciCalculator(int n)
    {
        BigInteger a = 0;
        BigInteger b = 1;

        for (int i = 0; i < n; i++)
        {
            var c = a + b;
            a = b;
            b = c;
        }

        return b;
    }
}