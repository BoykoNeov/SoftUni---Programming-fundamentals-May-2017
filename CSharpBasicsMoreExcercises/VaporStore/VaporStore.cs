/// <summary>
/// After the previous problem, you feel like taking a break, so you go on the Vapor Store to buy some video games. Write a program, which
/// helps you buy the games. The valid games are the following games in this table:
/// Name Price
/// OutFall 4	$39.99
/// CS: OG	$15.99
/// Zplinter Zell   $19.99
/// Honored 2	$59.99
/// RoverWatch	$29.99
/// RoverWatch Origins Edition	$39.99
/// On the first line, you will receive your current balance – a floating-point number in the range[0.00…5000.00].
/// Until you receive the command “Game Time”, you have to keep buying games.When a game is bought, 
/// the user’s balance decreases by the price of the game.
/// Additionally, the program should obey the following conditions:
/// If a game the user is trying to buy is not present in the table above, print “Not Found” and read the next line.
/// If at any point, the user has $0 left, print “Out of money!” and end the program.
/// Alternatively, if the user is trying to buy a game which they can’t afford, print “Too Expensive” and read the next line.
/// When you receive “Game Time”, print the user’s remaining money and total spent on games, rounded to the 2nd decimal place.
/// </summary>
using System;
using System.Collections.Generic;

public class VaporStore
{
    public static void Main()
    {
        decimal currentBalance = decimal.Parse(Console.ReadLine());

        decimal totalMoney = currentBalance;

        Dictionary<string, decimal> gamesDictionary = new Dictionary<string, decimal>()
            {
                {"OutFall 4" , 39.99m},
                {"CS: OG" , 15.99m},
                {"Zplinter Zell" , 19.99m},
                {"Honored 2" , 59.99m},
                {"RoverWatch" , 29.99m},
                {"RoverWatch Origins Edition" , 39.99m},
            };

        string buyingOrder = string.Empty;

        while ((buyingOrder = Console.ReadLine()) != "Game Time")
        {
            if (gamesDictionary.ContainsKey(buyingOrder))
            {
                string currentGame = buyingOrder;
                decimal currentGamePrice = gamesDictionary[currentGame];

                if (currentBalance >= currentGamePrice)
                {
                    currentBalance -= currentGamePrice;
                    Console.WriteLine($"Bought {currentGame}");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }

                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }

        decimal remainingMoney = totalMoney - currentBalance;
        Console.WriteLine($"Total spent: ${remainingMoney:F2}. Remaining: ${currentBalance:F2}");
    }
}