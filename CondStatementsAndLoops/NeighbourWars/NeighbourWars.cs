/// <summary>
/// Gosho and Pesho are neighbours, but they don’t like each other very much. 
/// They don’t like violence as well, so they decided they need a save environment 
/// where they can fight each other. They hired you to write a program, which calculates who would win the fight. 
/// Gosho and Pesho have their own signature attacks – Gosho attacks with “Thunderous fist”
/// on every even turn of the game and Pesho attacks with “Roundhouse kick” on every odd 
/// turn.You will receive how much damage these attacks do from the console.
/// Both players start with 100 Health points. On every third turn Pesho and Gosho restore 10 Health Points. 
/// Health points are restored after the attack is made.
/// When one of the player’s health is below or equal to zero you should stop any other further operations and 
/// print who the winner is, how much health points he has and in which turn he won. Since Mike Tyson is the judge 
/// of the match, the winning round is always printed with “th” in the end.
/// Input
/// The input is read from the console and consists of two lines:
/// First line – Pesho’s damage
/// Second line – Gosho’s damage
/// Output
/// Print on every turn who is attacking and how much health the opponent is after the attack:
/// "{name of the attacker} used {name of the attack} and reduced {name of the defending player} to {health of the defending player} health."
/// When one of the players is dead print:
/// "{name of the winner} won in {number of the round}th round."
/// Constraints
/// Pesho’s damage and Gosho’s damage will be integers in the interval [0…100]
/// There will always be a winner
/// </summary>
using System;

public class NeighbourWars
{
    public static void Main()
    {
        int peshoDamage = int.Parse(Console.ReadLine());
        int goshoDamage = int.Parse(Console.ReadLine());

        int peshoHitPoints = 100;
        int goshoHitPoints = 100;

        int roundCounter = 1;

        while (peshoHitPoints > 0 || goshoHitPoints > 0)
        {
            if (roundCounter % 2 == 0)
            {
                peshoHitPoints -= goshoDamage;

                if (peshoHitPoints <= 0)
                {
                    Console.WriteLine($"Gosho won in {roundCounter}th round.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHitPoints} health.");
                }
            }
            else
            {
                goshoHitPoints -= peshoDamage;

                if (goshoHitPoints <= 0)
                {
                    Console.WriteLine($"Pesho won in {roundCounter}th round.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHitPoints} health.");
                }
            }

            if (roundCounter % 3 == 0)
            {
                peshoHitPoints += 10;
                goshoHitPoints += 10;
            }

            roundCounter++;
        }
    }
}