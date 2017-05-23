/// <summary>
/// Task "Rectangle Area"
/// Write a program, which calculates a rectangle’s area, based on its width and height.
/// The width and height come as floating point numbers on the console,
/// formatted to the 2nd character after the decimal point.
/// </summary>
namespace RectangleArea
{
    using System;

    class RectangleArea
    {
        public static void Main()
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double area = height * width;
            Console.WriteLine($"{area:f2}");
        }
    }
}