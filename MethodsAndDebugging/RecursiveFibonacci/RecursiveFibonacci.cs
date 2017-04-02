//Calculate a Fibonacci sequence to n-th number (or n-th + 1, depending on definition) using recursion or not

using System;
using System.Numerics;
using System.Diagnostics;
using System.Threading;

public class RecursiveFibonacci
{
    public static void Main()
    {
        Console.WriteLine("Enter which number of the Fibonacci sequence do you want to be displayed:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Do you want to use recursion? Y/N, (default \"Yes\")");
        BigInteger result = 0;
        Stopwatch timer = new Stopwatch();
        if (Console.ReadLine() == "N")
        {
            timer.Start();
           Console.WriteLine(NonRecursiveFibonacciCalculator(n));
            timer.Stop();
            Console.WriteLine($"Elapsed time using non-recursion: {timer.Elapsed}");
        }
        else
        {
            timer.Start();
            Console.WriteLine(RecursiveFibonacciCalculator(0, 1, 0, n));
            timer.Stop();
            Console.WriteLine($"Elapsed time using recursion: {timer.Elapsed}");
        }

    }

    public static BigInteger RecursiveFibonacciCalculator(BigInteger a, BigInteger b, int counter, int n)
    {
        counter++;
        a = a + b;
        if (counter >= n)
        {
            return a;
        }
        else return RecursiveFibonacciCalculator(b, a, counter, n);
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