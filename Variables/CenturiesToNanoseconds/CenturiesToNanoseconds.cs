/// <summary>
/// Write program to enter an integer number of centuries and convert it to years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds.
/// </summary>
using System;
public class CenturiesToNanoseconds
{
    public static void Main()
    {
        int centuries = int.Parse(Console.ReadLine());
        int years = centuries * 100;
        int days = (int)(years * 365.2422);
        long hours = (long)(days * 24);
        long minutes = hours * 60;
        ulong seconds = (ulong)(minutes * 60);
        ulong miliseconds = (ulong)(seconds * 1000);
        decimal microseconds = miliseconds * 1000;
        decimal nanoseconds = microseconds * 1000;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}