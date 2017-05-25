/// <summary>
/// A restaurant want to automate their reservation process. They need a program that
/// reads the hall and the count of people from the console and calculates how much the customer should pay to book the place.
/// Different halls have different prices:
/// Small Hall  Terrace Great Hall
/// Price   2500$	5000$	7500$
/// Capacity	50	100	120
/// The restaurant has discounts depending on the service package, which the group wants.
/// You can see the discounts in the table below:
/// Normal Gold    Platinum
/// Discount	5%	10%	15%
/// Price   500$	750$	1000$
/// You should add the price of the package to the price of the hall. The discount is calculated based on the hall’s price + package’s price.
/// 20
/// Gold We can offer you the Small Hall
/// The price per person is 146.25$
/// 90
/// Platinum We can offer you the Terrace
/// The price per person is 56.67$
/// 150
/// Normal We do not have an appropriate hall.
/// </summary>
using System;

public class RestaurantDiscount
{
    public static void Main()
    {
        int customersCount = int.Parse(Console.ReadLine());
        string servicePackage = Console.ReadLine();
        decimal totalPrice = 0;
        decimal hallPrice = 0;
        string hall = string.Empty;

        if (customersCount > 120)
        {
            Console.WriteLine("We do not have an appropriate hall.");
            return;
        }
        else if (customersCount >= 100)
        {
            hallPrice = 7500;
            hall = "Great Hall";
        }
        else if (customersCount > 50)
        {
            hallPrice = 5000;
            hall = "Terrace";
        }
        else
        {
            hallPrice = 2500;
            hall = "Small Hall";
        }

        totalPrice += hallPrice;

        decimal discount = 0;

        switch (servicePackage)
        {
            case "Gold":
                discount = 0.10m;
                totalPrice += 750;
                break;

            case "Platinum":
                discount = 0.15m;
                totalPrice += 1000;
                break;

            case "Normal":
                discount = 0.05m;
                totalPrice += 500;
                break;
        }

        decimal pricePerPerson = 0;
        pricePerPerson = (totalPrice - (totalPrice * discount)) / customersCount;

        Console.WriteLine($"We can offer you the {hall}");
        Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
    }
}