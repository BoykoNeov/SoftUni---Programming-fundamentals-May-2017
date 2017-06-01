/// <summary>
/// Create a program to ask the user for a distance (in meters) and the time taken
/// (as three numbers: hours, minutes, seconds), and print the speed, in meters per second, kilometers per hour and miles per hour.
/// Assume 1 mile = 1609 meters.
/// </summary>
using System;
public class ConvertSpeedUnits
{
    public static void Main()
    {
        float distanceInMeters = float.Parse(Console.ReadLine());
        long hours = long.Parse(Console.ReadLine());
        long minutes = long.Parse(Console.ReadLine());
        long seconds = long.Parse(Console.ReadLine());

        float hoursInMinutes = hours * 60f;
        float minInseconds = (minutes + hoursInMinutes) * 60f;
        float totoalSeconds = minInseconds + seconds;

        float metersPerSeconds = distanceInMeters / totoalSeconds;
        float kmPerHour = (distanceInMeters / 1000f) / (totoalSeconds / 3600f);
        float milesPerHour = (distanceInMeters / 1609f) / (totoalSeconds / 3600f);

        Console.WriteLine((float)metersPerSeconds);
        Console.WriteLine((float)kmPerHour);
        Console.WriteLine((float)milesPerHour);
    }
}