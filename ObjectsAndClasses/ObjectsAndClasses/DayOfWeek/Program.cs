// You are given a date in format day-month-year. Calculate and print the day of week in English.

using System;
using System.Globalization;

public class DayOfWeek
{
    public static void Main()
    {
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine(date.DayOfWeek);
    }
}