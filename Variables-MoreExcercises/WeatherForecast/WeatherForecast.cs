/// <summary>
/// You invented a new groundbreaking technology to predict the weather, using numerology. You will be given a number from the console and with it, you can predict tomorrow’s weather. Your system works in the following way:
/// If the number can fit in sbyte (for C#) or byte (for Java) – the weather will be “Sunny”
/// If the numbers can fit in int – the weather will be “Cloudy”
/// If the number fits in long – the weather will be “Windy”
/// If it is floating point number – the weather will be “Rainy”
/// Always print the smallest possible option.
/// </summary>
using System;

public class WeatherForecast
{
    public static void Main()
    {
        //I am wondering how to write this in a more idiotic way to present at least the slightest interest
        string input = Console.ReadLine();

        try
        {
            sbyte.Parse(input);
            Console.WriteLine("Sunny");
        }
        catch
        {
            try
            {
                int.Parse(input);
                Console.WriteLine("Cloudy");
            }
            catch
            {
                try
                {
                    long.Parse(input);
                    Console.WriteLine("Windy");
                }
                catch
                {
                    Console.WriteLine("Rainy");
                }
            }
        }
    }
}