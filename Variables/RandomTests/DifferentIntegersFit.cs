using System;
using System.Numerics;

public class DifferentIntegersSizeFit
{
    public static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        bool sbyteFit = false;
        bool byteFit = false;
        bool shortFit = false;
        bool ushortFit = false;
        bool intFit = false;
        bool uintFit = false;
        bool longFit = false;

        // (sbyte < byte < short < ushort < int < uint < long).
        if (sbyte.MaxValue >= n && sbyte.MinValue <= n) sbyteFit = true;
        if (byte.MaxValue >= n && byte.MinValue <= n) byteFit = true;
        if (short.MaxValue >= n && short.MinValue <= n) shortFit = true;
        if (ushort.MaxValue >= n && ushort.MinValue <= n) ushortFit = true;
        if (int.MaxValue >= n && int.MinValue <= n) intFit = true;
        if (uint.MaxValue >= n && uint.MinValue <= n) uintFit = true;
        if (long.MaxValue >= n && long.MinValue <= n) longFit = true;

        if (shortFit || byteFit || shortFit || ushortFit || intFit || uintFit || longFit)
        {
            Console.WriteLine($"{n} can fit in:");
            if (sbyteFit) Console.WriteLine("* sbyte");
            if (byteFit) Console.WriteLine("* byte");
            if (shortFit) Console.WriteLine("* short");
            if (ushortFit) Console.WriteLine("* ushort");
            if (intFit) Console.WriteLine("* int");
            if (uintFit) Console.WriteLine("* uint");
            if (longFit) Console.WriteLine("* long");
        }
        else
        {
            Console.WriteLine($"{n} can't fit in any type");
        }
    }
}