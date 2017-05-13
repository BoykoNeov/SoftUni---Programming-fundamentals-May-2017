/// <summary>
/// ####Problem Description** Every year a charity marathon takes place in your town in which all major companies are obliged to make donations depending on the total kilometers ran by runners in a number of days. And this year you have been chosen to create the software for it. The marathon can last for variable number days and a variable number of runners can participate in it on a track that can have a variable length. However, the track that can take only a limited number of runners per day. If the runners that want to take part are more than the capacity, then the number of runners that will run will be equal to the maximum capacity of the track. The amount of money raised per kilometer is voted in advance by all companies and the final money per kilometer is calculated by an average of all votes. The goal is simple, create a program that calculates the total money raised through the marathon.
/// ####Input
/// On the first line of input you will get the length of the marathon in days
/// On the second line of input you will get the number of runners that will participate
/// On the third line you will get the average number of laps every runner makes
/// On the fourth line you will get the length of the track
/// On the fifth line you will get the capacity of the track
/// On the sixth line you will get the amount of money donated per kilometer
/// #####Output
/// Print the money raised, rounded by the second digit after the decimal point from the charity marathon in the format: "Money raised: {money}"
/// ####Constraints
/// Marathon day count will be an integer in the range[0 … 365]
/// Runner count will be an integer in the range[0 … 2, 147, 483, 647]
/// Average number of laps will be an integer in the range[0 … 100]
/// Lap length will be an integer in the range[0 … 2, 147, 483, 647]
/// Track capacity will be an integer in the range[0 … 1000]
/// Money per kilometer will all be a floating point number
/// </summary>
namespace CharityMarathon
{
    using System;

    public class CharityMarathon
    {
        public static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int runners = int.Parse(Console.ReadLine());
            int laps = int.Parse(Console.ReadLine());
            decimal trackLength = decimal.Parse(Console.ReadLine()) / 1000;
            int trackCapacity = int.Parse(Console.ReadLine());
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

            decimal participatingRunners = 0;

            participatingRunners = Math.Min((trackCapacity * days), runners);

            decimal totalKMrun = trackLength * participatingRunners * laps;

            decimal totalMoneyRaised = 0;
            totalMoneyRaised = totalKMrun * moneyPerKilometer;
            Console.WriteLine($"Money raised: {totalMoneyRaised:f2}");
        }
    }
}