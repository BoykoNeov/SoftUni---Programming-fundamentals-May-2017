/// <summary>
/// Write a program, which calculates the volume of n beer kegs. You will receive in total 3 * n lines.
/// Each three lines will hold information for a single keg. First up is the model of the keg, after that 
/// is the radius of the keg, and lastly is the height of the keg.
/// Calculate the volume using the following formula: π* r^2 * h.
/// At the end, print the model of the biggest keg.
/// Input
/// You will receive 3 * n lines. Each group of lines will be on a new line:
/// First – model – string.
/// Second –radius – floating-point number
/// Third – height – integer number
/// Output
/// Print the model of the biggest keg.
/// </summary>
using System;

public class BeerKegs
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string biggestKeg = string.Empty;
        double biggestVolume = 0;

        for (int i = 0; i < n; i++)
        {
            string kegName = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double volume = Math.PI * radius * radius * height;
            
            if (volume > biggestVolume)
            {
                biggestVolume = volume;
                biggestKeg = kegName;
            }
        }

        Console.WriteLine(biggestKeg);
    }
}