/// <summary>
/// Write a program to read n points and find the closest two of them.
/// </summary>
namespace ClosestTwoPoints
{
    using System;
    using System.Linq;

    public class ClosestTwoPoints
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            double minDisntace = double.MaxValue;
            Point outputA = new Point();
            Point outputB = new Point();

            for (int i = 0; i < n; i++)
            {
                double[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                points[i] = new Point();
                points[i].X = input[0];
                points[i].Y = input[1];
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    double distance = Math.Sqrt(Math.Pow((points[i].X - points[j].X), 2) + Math.Pow((points[i].Y - points[j].Y), 2));
                    if (distance < minDisntace)
                    {
                        outputA = points[i];
                        outputB = points[j];
                        minDisntace = distance;
                    }
                }
            }

            Console.WriteLine($"{minDisntace:f3}");
            Console.WriteLine($"({outputA.X}, {outputA.Y})");
            Console.WriteLine($"({outputB.X}, {outputB.Y})");
        }
    }
}
