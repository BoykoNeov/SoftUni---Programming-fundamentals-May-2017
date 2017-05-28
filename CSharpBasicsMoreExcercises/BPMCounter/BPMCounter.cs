/// <summary>
/// Problem 5.	BPM Counter
/// Write a program, which receives BPM(beats per minute) and number of beats
/// from the console and calculates how many bars(1 bar == 4 beats) the beats equal to, then calculates 
/// the length of the sequence in minutes and seconds.
/// The bars must always be rounded to the first digit after the decimal point(i.e. 1.75 bars  1.8 bars).
/// </summary>
using System;
public class BPMCounter
{
    public static void Main()
    {
        int BPM = int.Parse(Console.ReadLine());
        double beatsCount = double.Parse(Console.ReadLine());

        double seconds = (beatsCount / BPM) * 60;
        int mins = (int)seconds / 60;
        double additionalSeconds = (int)seconds % 60;

        Console.WriteLine($"{Math.Round(beatsCount / 4, 1)} bars - {mins}m {additionalSeconds}s");
    }
}