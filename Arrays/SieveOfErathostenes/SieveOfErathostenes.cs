// Write a program to find all prime numbers in range[1…n]. Implement the algorithm called “Sieve of Eratosthenes”

using System;
using System.Collections.Generic;

public class SieveOfErathostenes
{
    public static void Main()
    {
        // reads the limit number from the console and creates a bool array
        // with size n+1 (because the need to include also '0'. Assign true to all numbers
        int limit = int.Parse(Console.ReadLine());
        bool[] isPrime = new bool[limit + 1];
        for (int i = 0; i < isPrime.Length; i++)
        {
            isPrime[i] = true;
        }

        var primesList = new List<int>();

        // Performs the Sieve of Erathostenes algorithm until square of current number is above the limit
        for (int i = 2; i <= limit; i++)
        {
            if (isPrime[i] == true)
            {
                primesList.Add(i);
                for (int j = i; j < isPrime.Length; j += i)
                {
                    isPrime[j] = false;
                }
            }

            if (i * i >= limit)
            {
                break;
            }
        }

        for (int i = 2; i <= limit; i++)
        {
            if (isPrime[i] == true && !primesList.Contains(i))
            {
                primesList.Add(i);
            }
        }

        Console.WriteLine(string.Join(" ", primesList));
    }
}