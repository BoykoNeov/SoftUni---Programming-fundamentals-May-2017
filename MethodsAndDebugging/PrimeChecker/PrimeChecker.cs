using System;

/// <summary>
/// Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. 
/// </summary>
public class PrimeChecker
{
    public static void Main()
    {
        Primes(long.Parse(Console.ReadLine()));
    }

    public static void Primes(long a)
    {
        if (a < 2)
        {
            Console.WriteLine("False");
            return;
        }

        bool isPrime = true;

        for (int j = 2; j <= Math.Sqrt(a); j++)
        {
            if (a % j == 0)
            {
                isPrime = false;
                break;
            }
        }

        Console.WriteLine(isPrime);
    }
}