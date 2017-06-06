using System;
using System.Numerics;

/// <summary>
/// Calculate factorial from a number and count its trailing zeros
/// </summary>
public class FactorialTrailingZeroes
{
    public static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        BigInteger mainResult = CalculateFactorial(number);
        string mainResultString = Convert.ToString(mainResult);
        int trailingZeros = 0;

        for (int x = mainResultString.Length - 1; x >= 0; x--)
        {
            if (mainResultString[x] == '0')
            {
                trailingZeros++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(trailingZeros);
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