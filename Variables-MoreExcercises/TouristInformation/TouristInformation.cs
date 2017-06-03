/// <summary>
/// Write a program, which helps tourists convert imperial units of measurement to metric units. Your program needs to support the following conversions:
/// miles to kilometers, inches to centimeters, feet to centimeters, yards to meters and gallons to liters. The conversion table looks like this:
/// {initial value} {initial imperial unit} = {converted value} {metric unit}
/// </summary>
using System;

public class TouristInformation
{
    public static void Main()
    {
        string unit = Console.ReadLine();
        decimal value = decimal.Parse(Console.ReadLine());

        switch (unit)
        {
            case "miles":
                Console.WriteLine($"{value} {unit} = {(value * 1.6m):f2} kilometers");
                break;

            case "inches":
                Console.WriteLine($"{value} {unit} = {(value * 2.54m):f2} centimeters");
                break;

            case "feet":
                Console.WriteLine($"{value} {unit} = {(value * 30m):f2} centimeters");
                break;

            case "yards":
                Console.WriteLine($"{value} {unit} = {(value * 0.91m):f2} meters");
                break;

            case "gallons":
                Console.WriteLine($"{value} {unit} = {(value * 3.8m):f2} liters");
                break;
        }
    }
}