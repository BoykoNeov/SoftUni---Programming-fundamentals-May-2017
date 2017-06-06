/// <summary>
/// Write a program that calculates and prints the n! for any n in the range [1…1000]
/// </summary>
using System;
using System.Numerics;
public class Factorial
{
    public static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        BigInteger mainResult = CalculateFactorial(number);
        string mainResultString = Convert.ToString(mainResult);

        Console.WriteLine(mainResultString);
    }

    public static BigInteger CalculateFactorial(BigInteger n)
    {
        BigInteger result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}