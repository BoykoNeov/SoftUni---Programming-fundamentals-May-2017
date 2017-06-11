using System;
using System.Linq;

/// <summary>
/// You are the main accountant for a group of bandits, whose main line of work is robbing banks and stores.
/// Your job is to calculate the score from the heist, calculating the price of the loot and taking the expenses into account.
/// On the first line, you will receive an array with two elements.The first element represents the price of 
/// the jewels and the second – the price of the gold.
/// On each of the next lines, you will receive input in the format “{loot} {heist expenses}” until you receive 
/// the command “Jail Time”. The loot will be a string containing random characters.The jewels will
/// be represented with the character “%” and the gold – with the character “$”. If you find either
/// from the symbols it means you have found one of the goodies.
/// Upon receiving “Jail Time” you have to calculate the total earnings and the total expenses from the
/// heists. If the total earnings are more or equal to the total expenses print: “Heists will continue.
/// Total earnings: { money earned}.”. Otherwise print: “Have to find another job.Lost: {money lost}.”.
/// Input
/// On the first line, you will receive an array of integers with two elements.
/// The first element is the price of the jewels.
/// The second element is the price of the gold.
/// Each of the next lines will contain information in the following format “{loot} {heist expenses}” 
/// The loot will be a string of random characters.
/// The heist expenses will be an integer number.
/// The last line of the input will always be “Jail Time” – signaling the end of the input.
/// Output
/// The output should consist of only one line:
/// If the total earnings are more or equal to the expenses print:
/// “Heists will continue. Total earnings: { money earned}.”
/// Alternatively, if the expenses are more than the total earnings print:
/// “Have to find another job.Lost: {money lost}.”
/// Constraints
/// Only a single whitespace will be used for the separator.
/// The array will have at most 100 elements.
/// You will receive at most 20 heists.
/// You will receive at least one valid loot item.
/// The heist expenses will be in the interval [1…2147483647].
/// The gold and jewel prices will be integers in the interval [1…2147483647].
/// </summary>
public class Heists
{
    public static void Main()
    {
        int[] lootPrices = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        long totalEarning = 0;
        long totalExpences = 0;
        int jelewsPrice = lootPrices[0];
        int goldPrice = lootPrices[1];

        string input = string.Empty;

        while ((input = Console.ReadLine()) != "Jail Time")
        {
            string[] inputParams = input.Split(new char[] { ' ' },StringSplitOptions.None).ToArray();
            string currentLoot = inputParams[0];
            long currentExpences = long.Parse(inputParams[1]);

            for (int i = 0; i < currentLoot.Length; i++)
            {
                if (currentLoot[i] == '%')
                {
                    totalEarning += jelewsPrice;
                }
                else if (currentLoot[i] == '$')
                {
                    totalEarning += goldPrice;
                }
            }

            totalExpences += currentExpences;
        }

        long criminalBalance = (totalEarning - totalExpences);

        if (totalEarning >= totalExpences)
        {
            Console.WriteLine($"Heists will continue. Total earnings: {criminalBalance}.");
        }
        else
        {
            Console.WriteLine($"Have to find another job. Lost: {Math.Abs(criminalBalance)}.");
        }
    }
}