using System;
/// <summary>
/// Write a program that can calculate the area of four different geometry figures - triangle, square, rectangle and circle.
/// On the first line you will get the figure type.Next you will get parameters for the chosen figure, each on a different line:
/// Triangle - side and height
/// Square - side
/// Rectangle - width and height
/// Circle - radius
/// The output should be rounded to the second digit after the decimal point:
/// </summary>
public class GeometryCalculator
{
    public static void Main()
    {
        string figureType = Console.ReadLine();
        double figureArea = 0;

        if (figureType.Equals("triangle"))
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            figureArea = side * height / 2;
        }
        else if (figureType.Equals("square"))
        {
            double side = double.Parse(Console.ReadLine());
            figureArea = side * side;
        }
        else if (figureType.Equals("rectangle"))
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            figureArea = width * height;
        }
        else if (figureType.Equals("circle"))
        {
            double radius = double.Parse(Console.ReadLine());
            figureArea = Math.PI * radius * radius;
        }

        Console.WriteLine($"{figureArea:f2}");
    }
}