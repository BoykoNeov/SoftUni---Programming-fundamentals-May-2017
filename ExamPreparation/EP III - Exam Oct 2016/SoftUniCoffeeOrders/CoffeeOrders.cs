/// <summary>
/// We are placing N orders at a time. You need to calculate the price after the discount based on the following formula:
/// ((daysInMonth* capsulesCount) * pricePerCapsule)
/// * Hint – The DateTime class may come in handy to calculate the days in month.
/// Input / Constraints
/// On the first line you will receive integer N – the count of orders the shop will receive.
/// For each order you will receive the following information:
/// Price per capsule - floating-point number in range[0…79, 228, 162, 514, 264, 337, 593, 543, 950, 335].
/// Order date - in the following format { d / M / yyyy}, e.g. 25/11/2016, 7/03/2016, 1/1/2020.
/// Capsules count - integer in range[0…2, 147, 483, 647].
/// The input will be in the described format, there is no need to check it explicitly.
/// Output
/// The output should consist of N + 1 lines.For each order you must print a single line in the following format:
/// “The price for the coffee is: ${ price}”
/// On the last line you need to print the total price in the following format:
/// “Total: ${totalPrice}”
/// The price must be rounded to 2 decimal places
/// </summary>
namespace SoftUniCoffeeOrders
{
    using System;
    using System.Globalization;

    public class CoffeeOrders
    {
        public static void Main()
        {
            int orders = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int i = 0; i < orders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                string inputDate = Console.ReadLine();
                string format = @"d/M/yyyy";
                DateTime date = DateTime.ParseExact(inputDate, format, CultureInfo.InvariantCulture);
                int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
                long capsulesCount = long.Parse(Console.ReadLine());
                decimal orderPrice = ((daysInMonth * capsulesCount) * pricePerCapsule);

                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
                totalPrice += orderPrice;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}