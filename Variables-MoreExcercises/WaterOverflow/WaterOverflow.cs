/// <summary>
/// You have a water tank with capacity of 255 liters. On the next n lines, you 
/// will receive liters of water, which you have to pour in your tank. If the capacity
/// is not enough, print “Insufficient capacity!” and continue reading the next 
/// line. On the last line, print the liters in the tank.
/// </summary>
using System;

public class WaterOverflow
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int waterLimit = 255;
        int currentWater = 0;
        for (int i = 0; i < n; i++)
        {
            int inputWater = int.Parse(Console.ReadLine());
            if (currentWater + inputWater > waterLimit)
            {
                Console.WriteLine("Insufficient capacity!");
            }
            else
            {
                currentWater += inputWater;
            }
        }

        Console.WriteLine(currentWater);
    }
}