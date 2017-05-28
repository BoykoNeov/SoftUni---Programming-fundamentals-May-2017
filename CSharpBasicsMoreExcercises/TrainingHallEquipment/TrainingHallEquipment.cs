/// <summary>
/// As the new intern in SoftUni, you’re tasked with equipping the new training halls with all the necessary 
/// items to lead quality technical trainings. You’ll be given a budget and a list of items to buy. The other 
/// intern will be tasked with plugging in everything and hopefully not getting anyone electrocuted in the process…
/// Input
/// On the first line, you will receive your budget – a floating-point value in the range[0…1000000]
/// On the second line, you will receive the number of items you need to buy – an integer in the range[0…10]
/// On the next count*3 lines, you will receive the item data as such:
/// The item name – string
/// The item price – floating-point value in the range[0.50…1000.00]
/// The item count – integer in the range[0…1000]
/// Output
/// Every time an item is added to the cart, print “Adding {count} {item} to cart.”
/// on the console.Make sure to pluralize item names (if the item count isn’t 1, add an S at the 
/// end of the item name). After all of the items have been added to the cart, you need to calculate
/// the subtotal of the items and check if the budget will be enough.
/// If it’s enough, print “Money left: ${moneyLeft}”, formatted to the 2nd decimal point.
/// Otherwise, print “Not enough. We need ${ moneyNeeded}
/// more.”, formatted to the 2nd decimal point.
/// </summary>
using System;
public class TrainingHallEquipment
{
    public static void Main()
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        double itemsCount = double.Parse(Console.ReadLine());
        decimal moneySpent = 0;
        for (int i = 0; i < itemsCount; i++)
        {
            string equipment = Console.ReadLine();

            decimal price = decimal.Parse(Console.ReadLine());
            decimal quantity = decimal.Parse(Console.ReadLine());

            moneySpent += price * quantity;
            if (quantity <= 2)
            {
                Console.WriteLine($"Adding {quantity} {equipment}s to cart.");
            }
            else
            {
                Console.WriteLine($"Adding {quantity} {equipment}s to cart.");
            }
        }

        if (moneySpent > budget)
        {
            Console.WriteLine($"Subtotal: ${Math.Abs(moneySpent):F2}");
            Console.WriteLine($"Not enough. We need ${moneySpent - budget:F2} more.");
        }
        else
        {
            Console.WriteLine($"Subtotal: ${moneySpent:F2}");
            Console.WriteLine($"Money left: ${Math.Abs(budget - moneySpent):F2}");
        }
    }
}