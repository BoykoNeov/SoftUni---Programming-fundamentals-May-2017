using System;
/// <summary>
/// Create a program to calculate rectangle’s perimeter, area and diagonal by given its width and height.
/// </summary>
public class RectangleProperties
{
    public static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * (width + height);
        double area = width * height;
        double diagonal = Math.Sqrt((width * width) + (height * height));

        Console.WriteLine(perimeter);
        Console.WriteLine(area);
        Console.WriteLine(diagonal);
    }
}