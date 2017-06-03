/// <summary>
/// You are a house builder and you need to buy the materials for one of your clients.
/// This is quite a special house and it needs special materials. The house needs 4 sbyte variables and 10 int variables.
/// You will receive two numbers from the console, which will be the prices of 
/// the materials.One will be an integer and the other will be sbyte, but you 
/// do not know the order in which they will be given.The int number will be the 
/// price of the int materials and the sbyte number will be the price of the sbyte materials.
/// Calculate the total price of the materials and print them on the console.
/// </summary>
using System;
using System.Collections.Generic;

public class HouseBuilder
{
    public static void Main()
    {
        SortedSet<int> prices = new SortedSet<int>
        {
            int.Parse(Console.ReadLine()),
            int.Parse(Console.ReadLine())
        };

        decimal result = (4 * prices.Min) + (10m * prices.Max);
        Console.WriteLine(result);
    }
}