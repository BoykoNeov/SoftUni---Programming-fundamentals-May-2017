using System;
using System.Text;
using System.Diagnostics;

/// <summary>
/// Displays primes in a given range
/// </summary>
public class PrimesInRange
{
    public static void Main()
    {
        Primes(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
    }

    public static void Primes(int a, int b)
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();
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
        timer.Stop();
        output.Remove(output.Length - 2, 2);
        Console.WriteLine(output.ToString());
        Console.WriteLine($"Time elapsed to find all numbers between {a} and {b} : {timer.Elapsed}");
    }
}