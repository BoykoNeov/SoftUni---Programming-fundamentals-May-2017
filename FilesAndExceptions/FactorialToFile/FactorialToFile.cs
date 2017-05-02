using System;
using System.IO;
using System.Numerics;

/// <summary>
/// Calculate factorial from a number and write the result to a file
/// </summary>
public class FactorialToFile
{
    public static void Main()
    {
        Console.WriteLine("Enter output file name");
        string fileName = Console.ReadLine();

        Console.WriteLine("enter n!");
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        File.AppendAllText (fileName, Convert.ToString(CalculateFactorial(number)));
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