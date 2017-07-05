using System;

/// <summary>
/// Ivancho and his girlfriend are throwing a party. She plans to 
/// cook her favorite dessert. She asks Ivancho to buy the needed 
/// products. The number of desserts depends on how many people will be coming. She can prepare the dessert
/// in portions of 6. If there are 5 guests coming, she will still cook 6 portions, 10 guests – cook 12.
/// The products for the dessert are bananas, eggs and berries. For a set of 6 she needs 2 bananas, 4 eggs and 0.2 kilos berries.
/// You will be given the amount of money Ivancho has, the number
/// of guests and the prices of the products.You have to help Ivancho
/// calculate if the cash he has is enough to buy all of the products, or how much more money he needs.
/// Input
/// The input data should be read from the console.It will consist of exactly 5 lines:
/// The amount of cash Ivancho has – floating-point number in range[0.00…1, 000, 000, 000.00]
/// The number of guests – integer in range[0…1, 000, 000, 000]
/// The price of bananas for a single unit – floating-point number in range[0.00…1, 000.00]
/// The price of eggs for a single unit – floating-point number in range[0.00…1, 000.00]
/// The price of berries for a kilo – floating-point number in range[0.00…1, 000.00]
/// The input data will always be valid and in the format described.There is no need to check it explicitly.
/// Output
/// The output should be printed on the console.
/// If the calculated price of the products is less or equal to the money Ivancho has:
/// “Ivancho has enough money - it would cost { the cost of the products}
/// lv.”
/// If the calculated price of the products is more than the money Ivancho has:
///  “Ivancho will have to withdraw money - he will need {neededMoney}lv more.”
/// All prices must be rounded to two digits after the decimal point.
/// </summary>
public class SweetDesert
{
    public static void Main()
    {
        decimal startingMoney = decimal.Parse(Console.ReadLine());
        long guestsCount = long.Parse(Console.ReadLine());
        decimal bananasPrice = decimal.Parse(Console.ReadLine());
        decimal eggsPrice = decimal.Parse(Console.ReadLine());
        decimal berriesPrice = decimal.Parse(Console.ReadLine());

        long portionsNeeded = 0;

        if (guestsCount % 6 != 0)
        {
            portionsNeeded = guestsCount / 6 + 1;
        }
        else
        {
            portionsNeeded = guestsCount / 6;
        }

        decimal moneyNeeded = (2m * bananasPrice) * portionsNeeded;
        moneyNeeded += (4m * eggsPrice) * portionsNeeded;
        moneyNeeded += (0.2m * berriesPrice) * portionsNeeded;

        if (moneyNeeded <= startingMoney)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:f2}lv.");
        }
        else
        {
            Console.WriteLine($"Ivancho will have to withdraw money - he will need {(moneyNeeded - startingMoney):f2}lv more.");
        }
    }
}