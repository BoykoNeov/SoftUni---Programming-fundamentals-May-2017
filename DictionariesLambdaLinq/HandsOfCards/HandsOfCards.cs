// You are given a sequence of people and for every person what cards he draws from the deck.The input will be separate lines in the format:
// {personName}: {PT, PT, PT,… PT}
// Where P(2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A) is the power of the card and T(S, H, D, C) is the type.
// The input ends when a "JOKER" is drawn.The name can contain any ASCII symbol except ':'.
// The input will always be valid and in the format described, there is no need to check it.
// A single person cannot have more than one card with the same power and type, if he draws such a card he discards it.
// The people are playing with multiple decks.Each card has a value that is calculated by the power multiplied by the type. 
// Powers 2 to 10 have the same value and J to A are 11 to 14. 
// Types are mapped to multipliers the following way (S -> 4, H-> 3, D -> 2, C -> 1).
// Finally print out the total value each player has in his hand in the format:
// {personName}: {value}

using System;
using System.Collections.Generic;
using System.Linq;


public class HandsOfCards
{
    public static void Main()
    {
        var playerCards = new Dictionary<string, HashSet<string>>();

        while (true)
        {
            var inputs = Console.ReadLine().Split(new char[] { ':' }).ToList();
            string name = inputs[0];

            if (name == "JOKER")
            {
                break;
            }

            inputs = inputs[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var cards = new HashSet<string>();
            cards.UnionWith(inputs);

            if (!playerCards.ContainsKey(name))
            {
                playerCards.Add(name, cards);
            }
            else
            {
                playerCards[name].UnionWith(cards);
            }
        }

        var playerScores = new Dictionary<string, int>();

        foreach (var kvp in playerCards)
        {
            int score = 0;

            foreach (string card in kvp.Value)
            {
                int cardPower = 0;
                int cardType = 0;

                if (char.IsDigit(card[0]))
                {
                    cardPower = (int)char.GetNumericValue(card[0]);
                    if (cardPower == 1)
                    {
                        cardPower = 10;
                    }
                }
                else
                {
                    switch (card[0])
                    {
                        case 'J':
                            cardPower = 11;
                            break;
                        case 'Q':
                            cardPower = 12;
                            break;
                        case 'K':
                            cardPower = 13;
                            break;
                        case 'A':
                            cardPower = 14;
                            break;
                    }
                }

                switch (card[card.Length-1])
                {
                    case 'S':
                        cardType = 4;
                        break;

                    case 'H':
                        cardType = 3;
                        break;

                    case 'D':
                        cardType = 2;
                        break;

                    case 'C':
                        cardType = 1;
                        break;
                }

                score += (cardType * cardPower);
            }

            playerScores.Add(kvp.Key, score);
        }

        foreach (var kvp in playerScores)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}