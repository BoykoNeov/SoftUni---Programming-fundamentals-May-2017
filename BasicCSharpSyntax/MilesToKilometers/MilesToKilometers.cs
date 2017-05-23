/// <summary>
/// Write a program, which converts miles to kilometers. Format the output to the 2nd decimal place.
/// Note: 1 mile == 1.60934 kilometers
/// </summary>
namespace MilesToKilometers
{
    using System;

    public class MilesToKilometers
    {
        public static void Main()
        {
            const double mileToKM = 1.60934;
            double miles = double.Parse(Console.ReadLine());
            double kilometers = miles * mileToKM;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}