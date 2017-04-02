using System;
using System.Diagnostics;

public class FastPrimeCheckerRefactoring
{
    public static void Main()
    {
        Stopwatch timer = new Stopwatch();
        int upperBoundary = int.Parse(Console.ReadLine());
        timer.Start();
        int result = 0;

        for (int i = 2; i <= upperBoundary; i++)
        {
            bool isPrime = true;
            for (int numberChecked = 2; numberChecked <Math.Sqrt(i); numberChecked++)
            {
                if (i % numberChecked == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime == true)
            {
                result = i;
            }
        }
        timer.Stop();
        Console.WriteLine($"Largest found prime: {result} , time elapsed: {timer.Elapsed}");
    }
}