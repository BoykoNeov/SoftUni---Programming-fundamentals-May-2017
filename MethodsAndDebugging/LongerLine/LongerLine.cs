using System;
/// <summary>
/// You are given the coordinates of four points in the 2D plane. 
/// The first and the second pair of points form two different lines.
/// Print the longer line in format "(X1, Y1)(X2, Y2)" starting with the point 
/// hat is closer to the center of the coordinate system (0, 0) (You can reuse
/// the method that you wrote for the previous problem). If the lines are of
/// equal length, print only the first one.
/// </summary>
public class LongerLine
{
    public static void Main()
    {
        double firstX1 = double.Parse(Console.ReadLine());
        double firstY1 = double.Parse(Console.ReadLine());
        double firstX2 = double.Parse(Console.ReadLine());
        double firstY2 = double.Parse(Console.ReadLine());
        double secondX1 = double.Parse(Console.ReadLine());
        double secondY1 = double.Parse(Console.ReadLine());
        double secondX2 = double.Parse(Console.ReadLine());
        double secondY2 = double.Parse(Console.ReadLine());

        double firstDistance = Math.Sqrt(((firstX2 - firstX1) * (firstX2 - firstX1)) + ((firstY2 - firstY1) * (firstY2 - firstY1)));
        double secondDistance = Math.Sqrt(((secondX2 - secondX1) * (secondX2 - secondX1)) + ((secondY2 - secondY1) * (secondY2 - secondY1)));

        PrintLongerLine(firstX1, firstY1, firstX2, firstY2, secondX1, secondY1, secondX2, secondY2, firstDistance, secondDistance);
    }

    private static void PrintLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, double firstDistance, double secondDistance)
    {
        if (firstDistance >= secondDistance)
        {
            PrintClosePoint(x1, y1, x2, y2);
            PrintFarPoint(x1, y1, x2, y2);
        }
        else
        {
            PrintClosePoint(x3, y3, x4, y4);
            PrintFarPoint(x3, y3, x4, y4);
        }
    }

    private static void PrintFarPoint(double x1, double y1, double x2, double y2)
    {
        double firstRadius = (x1 * x1) + (y1 * y1);
        double secondRadius = (x2 * x2) + (y2 * y2);

        if (firstRadius > secondRadius)
        {
            Console.WriteLine($"({x1}, {y1})");
        }
        else
        {
            Console.WriteLine($"({x2}, {y2})");
        }
    }

    private static void PrintClosePoint(double x1, double y1, double x2, double y2)
    {
        double firstRadius = (x1 * x1) + (y1 * y1);
        double secondRadius = (x2 * x2) + (y2 * y2);

        if (firstRadius <= secondRadius)
        {
            Console.Write($"({x1}, {y1})");
        }
        else
        {
            Console.Write($"({x2}, {y2})");
        }
    }
}