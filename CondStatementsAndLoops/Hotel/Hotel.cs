/// <summary>
/// A hotel has three types of rooms: studio, double and master suite. The prices are different for the different months: 
/// May and October June and September  July, August and December
/// Studio - 50 leva per night Studio - 60 leva per night Studio - 68 leva per night
/// Double - 65 leva per night Double - 72 leva per night Double - 77 leva per night
/// Suite - 75 leva per night Suite - 82 leva per night Suite - 89 leva per night
/// They have also the following discounts: 
/// For studio and more than 7 nights in May and October: 5% discount
/// For double and more than 14 nights in June and September: 10% discount
/// For suite and more than 14 nights in July, August and December: 15% discount
/// For studio and more than 7 nights in September and October: one night is free
/// Input
/// The input consists of exactly 2 lines:
/// First line: Month – May, June, July, August, September, October or December
/// Second line: Nights Count – an integer between[0... 200]
/// Output
/// Print 3 lines on the console:
/// On the first: “Studio: {price for the stay} lv.”
/// On the second: “Double: {price for the stay} lv.”
/// On the third: “Suite: {price for the stay} lv.”
/// Format the prices to the 2nd decimal place.
/// </summary>
using System;
public class Hotel
{
    public static void Main()
    {
        string month = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());

        decimal studioPrice = 0;
        decimal doublePrice = 0;
        decimal suitePrice = 0;

        if (month == "May" || month == "October")
        {
            studioPrice = 50;
            doublePrice = 65;
            suitePrice = 75;

            if (nights > 7)
            {
                studioPrice = studioPrice * 0.95m;
            }
        }
        else if (month == "June" || month == "September")
        {
            studioPrice = 60;
            doublePrice = 72;
            suitePrice = 82;

            if (nights > 14)
            {
                doublePrice = doublePrice * 0.90m;
            }
        }
        else if (month == "July" || month == "August" || month == "December")
        {
            studioPrice = 68;
            doublePrice = 77;
            suitePrice = 89;

            if (nights > 14)
            {
                suitePrice = suitePrice * 0.85m;
            }
        }

        decimal totalDoublePrice = nights * doublePrice;
        decimal totalSuitePrice = nights * suitePrice;

        if ((month == "October" || month == "September") && nights > 7)
        {
            nights--;
        }
        decimal totalStudioPrice = nights * studioPrice;

        Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
        Console.WriteLine($"Double: {totalDoublePrice:f2} lv.");
        Console.WriteLine($"Suite: {totalSuitePrice:f2} lv.");
    }
}