// Enter two points coordinates and calculates which is closer to the center of the coordinate system

using System;

public class CenterPoint
{
    public static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double distanceFirstPoint = CalculateDistanceToCenter(x1, y1);
        double distanceSecondPoint = CalculateDistanceToCenter(x2, y2);

        if (distanceSecondPoint < distanceFirstPoint)
        {
            Console.WriteLine($"({x2}, {y2})");
        }
        else
        {
            Console.WriteLine($"({x1}, {y1})");
        }
    }

    public static double CalculateDistanceToCenter(double a, double b)
    {
        double result = Math.Sqrt((a * a) + (b * b));
        return result;
    }
}