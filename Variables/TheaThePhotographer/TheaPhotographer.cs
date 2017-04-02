using System;

public class TheaPhotographer
{
    public static void Main()
    {
        int totalPictures = int.Parse(Console.ReadLine());
        long filterTime = int.Parse(Console.ReadLine());
        decimal filterFactor = int.Parse(Console.ReadLine()) / 100m;
        long uploadTime = int.Parse(Console.ReadLine());

        long days = 0;
        long hours = 0;
        long minutes = 0;
        long seconds = 0;

        long totalTimeInSeconds = totalPictures * filterTime;
        totalTimeInSeconds = (long)((totalTimeInSeconds + (Math.Ceiling(totalPictures * filterFactor) * uploadTime)));

        days = totalTimeInSeconds / 86400;
        totalTimeInSeconds -= days * 86400;

        hours = totalTimeInSeconds / 3600;
        totalTimeInSeconds -= hours * 3600;

        minutes = totalTimeInSeconds / 60;
        totalTimeInSeconds -= minutes * 60;

        seconds = totalTimeInSeconds;
        Console.WriteLine($"{days}:{hours:00}:{minutes:00}:{seconds:00}");
    }
}