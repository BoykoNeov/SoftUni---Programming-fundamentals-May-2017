using System;

public class PokeMon
{
    public static void Main()
    {
        long nPower = long.Parse(Console.ReadLine());
        long nOriginalValue = nPower;
        long mDistance = long.Parse(Console.ReadLine());
        long exaustion = long.Parse(Console.ReadLine());

        long targetsCount = 0;

        while (nPower >= mDistance)
        {
            nPower -= mDistance;
            targetsCount++;

            if ((decimal)(nOriginalValue - nPower) / nOriginalValue == 0.5m)
            {
                if (exaustion != 0)
                {
                    nPower /= exaustion;
                }
            }
        }

        Console.WriteLine(nPower);
        Console.WriteLine(targetsCount);
    }
}