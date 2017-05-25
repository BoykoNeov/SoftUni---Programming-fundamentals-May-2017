/// <summary>
/// Problem 2.	Choose a Drink 2.0
/// Your program needs to get smarter.Now you will receive on the second line the quantities of the drink and you have to print the calculated the price.You can see the prices of the drinks in the table below:
/// /// Price  water = 0.70, coffee = 1.00, beer = 1.70, tea = 1.20
/// Input
/// The input will be on two lines:
/// On the first line, you will receive the profession
/// On the second line, you will receive the quantity as an integer. 
/// Output
/// Print the output in the following format:
/// The { profession}
/// has to pay {totalPrice}.
/// Format the price to the 2nd decimal place.
/// </summary>
using System;
public class ChoseADrink2
{
    public static void Main()
    {
        string profession = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());
        decimal totalPrice = 0;

        switch (profession)
        {
            case "Athlete":
                totalPrice = 0.70m * quantity;
                break;

            case "Businessman":
                totalPrice = 1m * quantity;
                break;

            case "Businesswoman":
                totalPrice = 1m * quantity;
                break;

            case "SoftUni Student":
                totalPrice = 1.70m * quantity;
                break;

            default:
                totalPrice = 1.20m * quantity;
                break;
        }

        Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
    }
}