// Write all primes in a range to file

using System;
using System.Text;
using System.IO;

public class PrimesInRangeToFile
{
    public static void Main()
    {
        Console.WriteLine("Enter the two numbers between which to find all prime numbers on separate lines");
        Console.WriteLine("(Second number must be bigger than the first, minimum valie of both number - \"2\"!)");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the name of the output file:");
        string outputFile = Console.ReadLine();

        if (a == 1) { }
        string output = Primes(a, b);
        File.AppendAllText(outputFile, output);
    }

    public static string Primes(int a, int b)
    {
        if (a < 2)
        {
            a = 2;
        }

        if (b < 2)
        {
            b = 2;
        }

        StringBuilder output = new StringBuilder();
        for (int i = a; i <= b; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                output.Append(i).Append(", ");
            }
        }

        output.Remove(output.Length - 2, 2);
        return (output.ToString());
    }
}










