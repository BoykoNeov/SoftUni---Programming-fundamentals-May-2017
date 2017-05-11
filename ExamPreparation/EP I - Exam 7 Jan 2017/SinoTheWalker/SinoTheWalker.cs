/// <summary>
///  You will receive the time that Sino leaves SoftUni, the steps taken and time for each step in seconds. You need to print the exact time that he will arrive at home in the format specified.
/// Input / Constrains
/// The first line will be the time Sino leaves SoftUni in the following format: HH:mm:ss
/// The second line will contain the number of steps that he needs to walk to his home.This number will be an integer in range[0…2, 147, 483, 647]
/// On the final line you will receive the time in seconds for each step. This number will be an integer in range[0…2, 147, 483, 647]
/// Output:
/// Print the time of arrival at home in the following format:
/// Time Arrival: { hours}:{minutes}:{seconds}
/// If hours, minutes or seconds are a single digit number, add a zero in front.
/// If, for example, hours are equal to zero, print a 00 in their place.The same is true for minutes or seconds.
/// Time of day starts at 00:00:00 and ends at 23:59:59
/// </summary>
namespace SinoTheWalker
{
    using System;
    using System.Globalization;

    public class SinoTheWalker
    {
       public static void Main()
        {
            string startTimeInput = Console.ReadLine();
            double numberOfSteps = double.Parse(Console.ReadLine());
            double eachStemTime = double.Parse(Console.ReadLine());

            DateTime startTime = new DateTime();
            string dateTimeFormat = "HH:mm:ss";
            startTime = DateTime.ParseExact(startTimeInput, dateTimeFormat, CultureInfo.InvariantCulture);

            // DateTime has limits, in order to get the correct result without reaching it's limits , the modulus of total seconds in a day can be taken
            const int secondsInADay = 86400;
            double secondsMultipliedBySteps = (numberOfSteps * eachStemTime) % secondsInADay;
            DateTime finalTime = startTime.AddSeconds(secondsMultipliedBySteps);
            Console.WriteLine($"Time Arrival: {finalTime.Hour:00}:{finalTime.Minute:00}:{finalTime.Second:00}");
        }
    }
}