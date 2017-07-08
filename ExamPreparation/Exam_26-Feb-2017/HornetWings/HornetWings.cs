using System;

public class HornetWings
{
    public static void Main()
    {
        long wingFlaps = long.Parse(Console.ReadLine());
        decimal distancePer1000flaps = decimal.Parse(Console.ReadLine());
        long endurance = long.Parse(Console.ReadLine());

        const int restTime = 5; //Hornet rests for 5 seconds
        const int flapsPerSecond = 100; // a hornet makes 100 wing flaps per second

        decimal time = 0;
        decimal distance = 0;

        decimal distancePer1flap = distancePer1000flaps / 1000m;
        distance = wingFlaps * distancePer1flap;

        time = wingFlaps / flapsPerSecond;
        time += restTime * (wingFlaps / endurance);

        Console.WriteLine($"{distance:f2} m.");
        Console.WriteLine($"{time:f0} s.");

    }
}