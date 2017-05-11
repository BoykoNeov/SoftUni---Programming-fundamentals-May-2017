/// <summary>
/// The goal of the Endurance Rally is, simply, to finish the race.
/// You are given the names of the participants, the track layout and the** checkpoint** indexes.
/// The starting fuel of each participant is equal to the ASCII code of the first character of his name.
/// Track layout consists of zones represented by numbers, given on a single line separated by a single space. Every number represents the fuel given or the fuel taken by the current zone of the track:
/// If the current zone is a checkpoint, the value of the zone is added to the driver's fuel.
/// If the current zone is not a checkpoint , the value of the zone is subtracted from the driver's fuel.
/// Zones are indexed.Indexes are sequential and always start from zero (like an array).
/// The checkpoints are numbers, representing indexes that show if a zone of the track** is a checkpoint**. For example, you are given checkpoints 0, 3 and 5, that means that zones at index 0, 3 and 5 of the track are checkpoints and therefore provide fuel for the driver.
/// Given this information, you need to check if a driver can finish and print the fuel that he is left with. If a driver can't finish you need to print the zone he managed to reach.
/// Input
/// The input will be read from the console.The input consists of exactly three lines :
/// The first line holds the drivers' names separated by a space: "{driver 1} {driver 2} … {driver N}"
/// On the second line is the track layout (zones) in the form of numbers separated by a space: "{zone 0} {zone 1} … {zone N}"
/// On the third line are the checkpoint indexes also separated by a space: "{index 0} {index 1} … {index N}"
/// Output
/// Print all drivers in the order of their appearance , each on a separate line:
/// If the driver finished, print his name and fuel left to the second digit after the decimal point in the format: "{driver name} - fuel left {fuel points}"
/// If the driver could not finish, print: "{driver name} - reached {zone index}"
/// Constrains
/// Drivers count will be in the range [0 … 200]
/// Zone fuel will be a floating-point number
/// </summary>
namespace EnduranceRally
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EnduranceRally
    {
        public static void Main()
        {
            string[] drivers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double[] zones = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();

            int[] checkpointsInput = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var checkpoints = new HashSet<int>();
            foreach (int checkpont in checkpointsInput)
            {
                checkpoints.Add(checkpont);
            }

            foreach (string driver in drivers)
            {
                double driverFuel = driver[0];
                int currentZone = 0;

                for (int i = 0; i < zones.Length; i++)
                {
                    currentZone = i;
                    if (checkpoints.Contains(i))
                    {
                        driverFuel += zones[i];
                    }
                    else
                    {
                        driverFuel -= zones[i];
                    }

                    if (driverFuel <= 0)
                    {
                       break;
                    }
                }

                if (driverFuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {driverFuel:f2}");
                }
                else
                {
                    Console.WriteLine($"{driver} - reached {currentZone}");
                }
            }
        }
    }
}