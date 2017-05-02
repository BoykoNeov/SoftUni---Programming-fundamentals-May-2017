/// <summary>
/// Write a method to calculate the distance between two points p1 {x1, y1} and p2 {x2, y2}. 
/// Write a program to read two points (given as two integers) and print the Euclidean distance between them.
/// </summary>
namespace DistanceBetweenPoints
{
    using System;
    using System.Linq;

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            double[] inputA = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            double[] inputB = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Point a = new Point() { X = inputA[0], Y = inputA[1] };
            Point b = new Point() { X = inputB[0], Y = inputB[1] };
            double distance = Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2));

            Console.WriteLine($"{distance:f3}");
        }
    }
}
